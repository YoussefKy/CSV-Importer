using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YK.XrmToolBox.CSVImporter.Core;

namespace YK.XrmToolBox.CSVImporter.Helpers
{
    class QueryHelper
    {
        /// <summary>
        /// Read the CSV file and store lines into dataLine objects.
        /// if there is a primary key or keys in the columns list, then the Entity object will be created 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        internal static List<DataLine> GetData( Context context , out string errorMessage )
        {
            errorMessage = string.Empty;
            List<DataLine> data = new List<DataLine> ( );
            int index = 1;
            int columnCount = context.ColumnItems.Count;
            using ( StreamReader streamReader = new StreamReader ( context.FilePath , true ) )
            {
                if ( streamReader.ReadLine ( ).Split ( ';' ).Count ( ) != columnCount )
                {
                    errorMessage = "File must contain " + columnCount + " lines.";
                }
                else
                {
                    switch ( context.QueryType )
                    {
                        case ColumnTypeCode.DynamicConditionExpression:
                            while ( !streamReader.EndOfStream )
                            {
                                index++;
                                data.Add ( new DataLine ( context , index , streamReader.ReadLine ( ) , columnCount ) );
                            }
                            break;
                        case ColumnTypeCode.StaticConditionExpression:
                            while ( !streamReader.EndOfStream )
                            {
                                index++;
                                data.Add ( new DataLine ( context , index , streamReader.ReadLine ( ) , columnCount ) );
                            }
                            break;
                        case ColumnTypeCode.PrimaryKey:
                            int primaryKeyItemIndex = context.ColumnItems.Where ( a => a.ColumnType == ColumnTypeCode.PrimaryKey ).Select ( a => context.ColumnItems.IndexOf ( a ) ).FirstOrDefault();
                            while ( !streamReader.EndOfStream )
                            {
                                index++;
                                // + the index of the guid 
                                data.Add ( new DataLine ( context , index , streamReader.ReadLine ( ) , columnCount, primaryKeyItemIndex ) );
                            }
                            break;
                        case ColumnTypeCode.Key:
                            int keyItemIndex = context.ColumnItems.Where ( a => a.ColumnType == ColumnTypeCode.Key ).Select ( a => context.ColumnItems.IndexOf ( a ) ).FirstOrDefault ( );
                            while ( !streamReader.EndOfStream )
                            {
                                index++;
                                //+ key name and index
                                data.Add ( new DataLine ( context , index , streamReader.ReadLine ( ) , columnCount, context.ColumnItems[ keyItemIndex].LogicalName, keyItemIndex ) );
                            }
                            break;
                        case ColumnTypeCode.PartialKey:
                            List<int> PartialKeyItems = context.ColumnItems.Where ( a => a.ColumnType == ColumnTypeCode.PartialKey ).Select ( a => context.ColumnItems.IndexOf ( a ) ).ToList ( );
                            KeyAttributeCollection keyCollection = new KeyAttributeCollection ( );
                            foreach ( var item in PartialKeyItems )
                            {
                                keyCollection.Add (context.ColumnItems[ item ].LogicalName, item );
                            }
                            while ( !streamReader.EndOfStream )
                            {
                                index++;
                                data.Add ( new DataLine ( context , index , streamReader.ReadLine ( ) , columnCount, keyCollection ) );
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            return data;
        }

        /// <summary>
        /// Building the organization requests to update data in Dynamics
        /// </summary>
        /// <param name="context"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal static List<OrganizationRequestCollection> GetUpdateRequestsList( Context context , List<DataLine> data )
        {
            List<OrganizationRequestCollection> updateRequestsList = new List<OrganizationRequestCollection> ( );
            OrganizationRequestCollection updateRequestsCollection = new OrganizationRequestCollection ( );
            updateRequestsList.Add ( updateRequestsCollection );
            int lastUpdateRequestsCollectionIndex = 0;
            int CurrentUpdateRequestIndex = 0;
            foreach ( DataLine dataLine in data )
            {
                if ( dataLine.IsOk && dataLine.Entity != null )
                {
                    foreach ( var item in context.ColumnItems.Where(a => a.ColumnType == ColumnTypeCode.AttributeToUpdate) )
                    {
                        dataLine.Entity [ item.LogicalName ] = dataLine.LineData [ context.ColumnItems.IndexOf(item) ];
                    }
                    
                    updateRequestsList [ lastUpdateRequestsCollectionIndex ].Add ( new UpdateRequest ( )
                    {
                        Target = dataLine.Entity
                    } );
                    dataLine.UpdateRequestsCollectionIndex = lastUpdateRequestsCollectionIndex;
                    dataLine.UpdateRequestIndex = CurrentUpdateRequestIndex;
                    CurrentUpdateRequestIndex++;

                    if ( updateRequestsList [ lastUpdateRequestsCollectionIndex ].Count ( ) >= context.BatchSize )
                    {
                        updateRequestsList.Add ( new OrganizationRequestCollection ( ) );
                        lastUpdateRequestsCollectionIndex++;
                        CurrentUpdateRequestIndex = 0;
                    }
                }
            }
            return updateRequestsList;
        }


        internal static void UpdateDataWithEntities( Context context , IOrganizationService service , ref List<DataLine> data )
        {
            OrganizationRequestCollection retrieveMultipleRequestsCollection = new OrganizationRequestCollection ( );
            int firstDataIndex = 0;
            int dataTotalCount = data.Count;
            for ( int i = 0 ; i < dataTotalCount ; i++ )
            {
                if ( data [ i ].IsOk )
                {
                    QueryExpression queryExpression = new QueryExpression
                    {
                        TopCount = 1 ,
                        ColumnSet = new ColumnSet ( false )
                    };
                    foreach ( var item in context.ColumnItems.Where(a=>a.ColumnType == ColumnTypeCode.DynamicConditionExpression ))
                    {
                        queryExpression.Criteria.AddCondition ( item.LogicalName , item.ConditionOperatorCode , data [ i ].LineData [ context.ColumnItems.IndexOf(item) ] );
                    }

                    retrieveMultipleRequestsCollection.Add ( new RetrieveMultipleRequest ( )
                    {
                        Query = queryExpression
                    } );

                    if ( retrieveMultipleRequestsCollection.Count ( ) >= context.BatchSize )
                    {
                        ExecuteRetrieveMultiple ( service , retrieveMultipleRequestsCollection , firstDataIndex , ref data );
                        //initialisation
                        retrieveMultipleRequestsCollection.Clear ( );
                        firstDataIndex = i + 1;
                    }
                }
            }
            if ( retrieveMultipleRequestsCollection.Count != 0 )
            {
                ExecuteRetrieveMultiple ( service , retrieveMultipleRequestsCollection , firstDataIndex , ref data );
            }
        }

        private static void ExecuteRetrieveMultiple( IOrganizationService service , OrganizationRequestCollection retrieveMultipleRequestsCollection , int firstDataIndex , ref List<DataLine> data )
        {
            //excute 
            ExecuteMultipleRequest executeMultipleRequest = new ExecuteMultipleRequest ( )
            {
                Requests = retrieveMultipleRequestsCollection ,
                Settings = new ExecuteMultipleSettings ( )
                {
                    ContinueOnError = true ,
                    ReturnResponses = true
                }
            };
            ExecuteMultipleResponse executeMultipleResponse = service.Execute ( executeMultipleRequest ) as ExecuteMultipleResponse;
            //Update the data list
            foreach ( ExecuteMultipleResponseItem response in executeMultipleResponse.Responses )
            {
                if ( ( response.Response is RetrieveMultipleResponse ) && ( ( response.Response as RetrieveMultipleResponse ).EntityCollection.Entities.Count > 0 ) )
                {
                    data [ firstDataIndex + response.RequestIndex ].Entity = ( response.Response as RetrieveMultipleResponse ).EntityCollection.Entities [ 0 ];
                }
            }
        }
    }
}
