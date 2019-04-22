using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YK.XrmToolBox.CSVImporter.Core
{
    internal class DataLine
    {
        #region Constructors 
        //Basic constructor, without building the entity 
        public DataLine( Context context , int lineNumber , string lineText , int columnCount )
        {
            IsOk = true;
            LineNumber = lineNumber;
            LineText = lineText;
            LineData = lineText.Split ( ';' );
            if ( LineData.Count ( ) != columnCount )
            {
                IsOk = false;
                ErrorMessage = "Invalid Row";
            }
        }
        //Using a primary Key
        public DataLine( Context context , int lineNumber , string lineText , int columnCount , int index ) : this ( context , lineNumber , lineText , columnCount )
        {
            if ( !IsOk )
                return;
            Guid entityId = Guid.Empty;
            if ( Guid.TryParse ( LineData [ index ] , out entityId ) )
            {
                Entity = new Entity ( context.EntityItem.EntityMetadata.LogicalName , entityId );
            }
            else
            {
                IsOk = false;
                ErrorMessage = LineData [ index ] + "in an invalid Guid";
            }
        }

        public DataLine( Context context , int lineNumber , string lineText , int columnCount , KeyAttributeCollection keyCollection ) : this ( context , lineNumber , lineText , columnCount )
        {
            if ( !IsOk )
                return;
            KeyAttributeCollection keyAttributeCollection = new KeyAttributeCollection ( );
            foreach ( var item in keyCollection )
            {
                keyAttributeCollection.Add ( item.Key , LineData [ ( int ) item.Value ] );
            }

            Entity = new Entity ( context.EntityItem.EntityMetadata.LogicalName , keyAttributeCollection );
        }

        public DataLine( Context context , int lineNumber , string lineText , int columnCount , string logicalName , int index ) : this ( context , lineNumber , lineText , columnCount )
        {
            if ( !IsOk )
                return;
            Entity = new Entity ( context.EntityItem.EntityMetadata.LogicalName , logicalName , LineData [ index ] );
        }
        #endregion

        public bool IsOk
        {
            get;
            set;
        }

        public Entity Entity
        {
            get;
            internal set;
        }

        public int LineNumber
        {
            get;
            internal set;
        }
        public string LineText
        {
            get;
            internal set;
        }
        public string [ ] LineData
        {
            get;
            private set;
        }

        public string ErrorMessage
        {
            get;
            internal set;
        }
        public int UpdateRequestsCollectionIndex
        {
            get;
            internal set;
        }
        public int UpdateRequestIndex
        {
            get;
            internal set;
        }
        public ExecuteMultipleResponseItem UpdateResponse
        {
            get;
            internal set;
        }

        internal void SetUpdateResponse( ExecuteMultipleResponseItem response )
        {
            UpdateResponse = response;
            if ( response.Fault != null && response.Fault.InnerFault != null)
            {
                ErrorMessage = response.Fault.ErrorCode + " : " + response.Fault.Message.ToString ( ).Replace('\n',' ');
                IsOk = false;
            }
        }
    }
}
