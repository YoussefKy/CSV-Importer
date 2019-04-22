using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using YK.XrmToolBox.CSVImporter.Helpers;
using Microsoft.Xrm.Sdk.Metadata;
using YK.XrmToolBox.CSVImporter.Core;
using Microsoft.Xrm.Sdk.Messages;
using System.IO;
using YK.XrmToolBox.CSVImporter.Forms;

namespace YK.XrmToolBox.CSVImporter
{
    public partial class CSVImporterControl : PluginControlBase
    {
        private Settings mySettings;
        private Context context;

        public CSVImporterControl()
        {
            InitializeComponent ( );
        }

        private void CSVImporterControl_Load( object sender , EventArgs e )
        {
            ShowInfoNotification ( "This plugin is under development, Please feel free to contact me for requests or advice. kl.yssf@gmail.com" , new Uri ( "https://github.com/K-Youssef/CSV-Importer" ) );

            // Loads or creates the settings for the plugin
            if ( !SettingsManager.Instance.TryLoad ( GetType ( ) , out mySettings ) )
            {
                mySettings = new Settings ( );

                LogWarning ( "Settings not found => a new settings file has been created!" );
            }
            else
            {
                LogInfo ( "Settings found and loaded" );
            }

            context = new Context ( );

            #region Set up the data grid view
            gridTemplateColumns.AutoGenerateColumns = false;
            gridTemplateColumns.AutoSize = true;

            gridTemplateColumns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTemplateColumns.DataSource = context.ColumnItems;


            DataGridViewColumn column = new DataGridViewTextBoxColumn ( );
            column.DataPropertyName = "ColumnType";
            column.Name = "ColumnType";
            column.HeaderText = "Column Type";
            gridTemplateColumns.Columns.Add ( column );
            column = new DataGridViewTextBoxColumn ( );
            column.DataPropertyName = "EntityItem";
            column.Name = "EntityItem";
            column.HeaderText = "Entity";
            gridTemplateColumns.Columns.Add ( column );
            column = new DataGridViewTextBoxColumn ( );
            column.DataPropertyName = "AttributeItem";
            column.Name = "AttributeItem";
            column.HeaderText = "Attribute";
            gridTemplateColumns.Columns.Add ( column );
            column = new DataGridViewTextBoxColumn ( );
            column.DataPropertyName = "LogicalName";
            column.Name = "LogicalName";
            column.HeaderText = "Logical Name";
            gridTemplateColumns.Columns.Add ( column );
            column = new DataGridViewTextBoxColumn ( );
            column.DataPropertyName = "ConditionOperatorCode";
            column.Name = "ConditionOperatorCode";
            column.HeaderText = "Condition Operator";
            gridTemplateColumns.Columns.Add ( column );
            column = new DataGridViewTextBoxColumn ( );
            column.DataPropertyName = "AttributeTypeCode";
            column.Name = "AttributeTypeCode";
            column.HeaderText = "Attribute Type";
            gridTemplateColumns.Columns.Add ( column );

            #endregion


            //Options Default Value
            //TODO
            cmbUnicity.SelectedIndex = 0;
        }

        private void tsbClose_Click( object sender , EventArgs e )
        {
            CloseTool ( );
        }

        private void tsbLoadEntities_Click( object sender , EventArgs e )
        {
            cmbSelectedEntity.Items.Clear ( );
            cmbAttributeForQuery.Items.Clear ( );
            cmbAttributeToUpdate.Items.Clear ( );
            cmbKey.Items.Clear ( );

            cmbSelectedEntity.Enabled = false;
            cmbAttributeForQuery.Enabled = false;
            cmbAttributeToUpdate.Enabled = false;
            cmbKey.Enabled = false;

            btnAddAttributeToUpdate.Enabled = false;
            btnAddQueryAttribute.Enabled = false;

            context.ColumnItems.Clear ( );
            GenerateTemplate ( );

            ExecuteMethod ( GetEntities );
        }

        private void GetEntities()
        {
            WorkAsync ( new WorkAsyncInfo
            {
                Message = "Getting entities" ,
                Work = ( worker , args ) =>
                {
                    args.Result = MetadataHelper.RetrieveAllEntities ( Service );
                } ,
                PostWorkCallBack = ( args ) =>
                {
                    if ( args.Error != null )
                    {
                        MessageBox.Show ( args.Error.ToString ( ) , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                    List<EntityMetadata> result = args.Result as List<EntityMetadata>;
                    if ( result != null )
                    {
                        foreach ( var item in result )
                        {
                            cmbSelectedEntity.Items.Add ( new EntityItem ( item ) );
                        }
                        cmbSelectedEntity.Enabled = true;
                    }
                }
            } );
        }

        #region From The XrmToolBox Template

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSVImporterControl_OnCloseTool( object sender , EventArgs e )
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save ( GetType ( ) , mySettings );
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection( IOrganizationService newService , ConnectionDetail detail , string actionName , object parameter )
        {
            base.UpdateConnection ( newService , detail , actionName , parameter );

            if ( mySettings != null && detail != null )
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo ( "Connection has changed to: {0}" , detail.WebApplicationUrl );
            }
        }

        #endregion

        private void cmbSelectedEntity_SelectedIndexChanged( object sender , EventArgs e )
        {
            context.EntityItem = cmbSelectedEntity.SelectedItem as EntityItem;

            cmbAttributeForQuery.Items.Clear ( );
            cmbAttributeToUpdate.Items.Clear ( );

            cmbKey.Items.Clear ( );
            cmbKey.Items.Add ( "Select a Key" );
            cmbKey.SelectedIndex = 0;

            context.ColumnItems.Clear ( );
            GenerateTemplate ( );

            ExecuteMethod ( GetAttributes );
        }


        private void GetAttributes()
        {
            WorkAsync ( new WorkAsyncInfo
            {
                Message = "Getting attributes" ,
                Work = ( worker , args ) =>
                {
                    args.Result = MetadataHelper.RetriveAllEntityAttributes ( Service , context.EntityItem.EntityMetadata.LogicalName );
                } ,
                PostWorkCallBack = ( args ) =>
                {
                    if ( args.Error != null )
                    {
                        MessageBox.Show ( args.Error.ToString ( ) , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                    }
                    if ( args.Result is EntityMetadata result )
                    {
                        context.EntityAttributes = result.Attributes;
                        foreach ( var item in result.Attributes )
                        {
                            if ( MetadataHelper.IsSupportedAttribute ( item ) )
                            {
                                cmbAttributeForQuery.Items.Add ( new AttributeItem ( item ) );
                                cmbAttributeToUpdate.Items.Add ( new AttributeItem ( item ) );
                            }
                            if ( item.IsPrimaryId != null && ( bool ) item.IsPrimaryId )
                            {
                                cmbKey.Items.Add ( new AttributeItem ( item ) );
                            }
                        }
                        foreach ( var item in result.Keys )
                        {
                            cmbKey.Items.Add ( new KeyItem ( item ) );
                        }
                        cmbAttributeForQuery.Enabled = false;
                        cmbAttributeToUpdate.Enabled = true;
                        cmbKey.Enabled = true;

                        btnAddAttributeToUpdate.Enabled = true;
                        btnAddQueryAttribute.Enabled = false;
                    }
                }
            } );
        }

        private void cmbKey_SelectedIndexChanged( object sender , EventArgs e )
        {
            RefreshDataGrid ( );
            if ( cmbKey.SelectedIndex < 1 )
            {
                context.IsKeyDetected = false;
                //todo
                cmbAttributeForQuery.Enabled = false;
                btnAddQueryAttribute.Enabled = false;
            }
            else
            {
                context.IsKeyDetected = true;
                cmbAttributeForQuery.Enabled = false;
                btnAddQueryAttribute.Enabled = false;
                //Add fields to the grid 
                if ( cmbKey.SelectedItem is KeyItem keyItem )
                {
                    if ( keyItem.EntityKeyMetadata.KeyAttributes.Count ( ) == 1 )
                    {
                        context.QueryType = ColumnTypeCode.Key;
                        AttributeItem attributeItem = new AttributeItem ( context.EntityAttributes.Where ( a => a.LogicalName == keyItem.EntityKeyMetadata.KeyAttributes [ 0 ] ).First ( ) );
                        context.ColumnItems.Add ( new ColumnItem ( ColumnTypeCode.Key , context.EntityItem , attributeItem , ConditionOperator.Equal ) );
                    }
                    else
                    {
                        context.QueryType = ColumnTypeCode.PartialKey;
                        foreach ( var item in keyItem.EntityKeyMetadata.KeyAttributes )
                        {
                            AttributeItem attributeItem = new AttributeItem ( context.EntityAttributes.Where ( a => a.LogicalName == item ).First ( ) );
                            context.ColumnItems.Add ( new ColumnItem ( ColumnTypeCode.PartialKey , context.EntityItem , attributeItem , ConditionOperator.Equal ) );
                        }
                    }
                }
                else if ( cmbKey.SelectedItem is AttributeItem PrimarykeyItem )
                {
                    context.QueryType = ColumnTypeCode.PrimaryKey;
                    context.ColumnItems.Add ( new ColumnItem ( ColumnTypeCode.PrimaryKey , context.EntityItem , PrimarykeyItem , ConditionOperator.Equal ) );
                }
            }
            GenerateTemplate ( );
        }

        private void RefreshDataGrid()
        {
            List<ColumnItem> toDelete = new List<ColumnItem> ( );
            foreach ( var item in context.ColumnItems )
            {
                if ( item.ColumnType == ColumnTypeCode.DynamicConditionExpression
                    || item.ColumnType == ColumnTypeCode.Key
                    || item.ColumnType == ColumnTypeCode.PartialKey
                    || item.ColumnType == ColumnTypeCode.PrimaryKey )
                {
                    toDelete.Add ( item );
                }
            }
            foreach ( var item in toDelete )
            {
                context.ColumnItems.Remove ( item );
            }
        }

        private void GenerateTemplate()
        {
            string firstLine = "File Template :\n";
            foreach ( var item in context.ColumnItems )
            {
                firstLine += item.AttributeItem.ToString ( ) + ";";
            }
            firstLine = firstLine.Substring ( 0 , firstLine.Length - 1 );
            lblFileTemplate.Text = firstLine;
        }

        private void btnAddAttributeToUpdate_Click( object sender , EventArgs e )
        {
            if ( cmbAttributeToUpdate.SelectedIndex >= 0 && cmbAttributeToUpdate.SelectedItem is AttributeItem attributeItem )
            {
                if ( context.ColumnItems.Any ( a => a.LogicalName == attributeItem.AttributeMetadata.LogicalName ) )
                {
                    //todo
                    MessageBox.Show ( "Attribute aleady added" , "CSV Importer" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                }
                else
                {
                    context.ColumnItems.Add ( new ColumnItem ( ColumnTypeCode.AttributeToUpdate , context.EntityItem , attributeItem ) );
                }
            }
            GenerateTemplate ( );
        }

        private void tsbImport_Click( object sender , EventArgs e )
        {
            //Organization Request Collection Limit Size
            context.BatchSize = ( int ) nudBatchSize.Value;
            context.MaxParallelism = ( int ) nudMaxParallelism.Value;
            context.Unicity = cmbUnicity.SelectedIndex;
            ExecuteMethod ( ExecuteImport );
        }

        private void btnAddQueryAttribute_Click( object sender , EventArgs e )
        {
            context.QueryType = ColumnTypeCode.DynamicConditionExpression;
            if ( cmbAttributeForQuery.SelectedIndex >= 0 && cmbAttributeForQuery.SelectedItem is AttributeItem attributeItem )
            {
                if ( cmbConditionOperator.SelectedIndex >= 0 && cmbConditionOperator.SelectedItem is ConditionOperator conditionOperator )
                {
                    context.ColumnItems.Add ( new ColumnItem ( ColumnTypeCode.DynamicConditionExpression , context.EntityItem , attributeItem , conditionOperator ) );
                }
                else
                {
                    context.ColumnItems.Add ( new ColumnItem ( ColumnTypeCode.DynamicConditionExpression , context.EntityItem , attributeItem , ConditionOperator.Equal ) );
                }
            }
            GenerateTemplate ( );
        }

        private void tsbBrowse_Click( object sender , EventArgs e )
        {
            string filePath = string.Empty;
            using ( OpenFileDialog openFileDialog = new OpenFileDialog ( ) )
            {
                openFileDialog.Filter = "CSV File (.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if ( openFileDialog.ShowDialog ( ) == DialogResult.OK )
                {
                    filePath = openFileDialog.FileName;
                }
            }
            context.FilePath = filePath;
            if ( string.IsNullOrEmpty ( filePath ) )
            {
                lblFilePath.Text = "Choose a CSV file with the given format";
            }
            else
            {
                lblFilePath.Text = filePath;
            }
        }

        #region Import

        private void ExecuteImport()
        {
            WorkAsync ( new WorkAsyncInfo ( "Importing csv file..." , ( w , e ) =>
            {
                w.WorkerReportsProgress = true;
                string errorMessage = string.Empty;
                w.ReportProgress ( 0 , "Reading the CSV file..." );
                List<DataLine> data = QueryHelper.GetData ( context , out errorMessage );

                if ( !context.IsKeyDetected )
                {
                    //get Entities
                    w.ReportProgress ( 0 , "getting Entities..." );
                    QueryHelper.UpdateDataWithEntities ( context , Service , ref data );
                }

                w.ReportProgress ( 0 , "Building Update requests..." );
                List<OrganizationRequestCollection> updateRequestsList = QueryHelper.GetUpdateRequestsList ( context , data );

                Action<OrganizationRequestCollection> executeMultipleAction = organizationRequestCollection =>
                {
                    ExecuteMultipleRequest executeMultipleRequest = new ExecuteMultipleRequest ( )
                    {
                        Requests = organizationRequestCollection ,
                        Settings = new ExecuteMultipleSettings ( )
                        {
                            ContinueOnError = true ,
                            ReturnResponses = true
                        }
                    };
                    try
                    {
                        ExecuteMultipleResponse executeMultipleResponse = Service.Execute ( executeMultipleRequest ) as ExecuteMultipleResponse;
                        if ( executeMultipleResponse.IsFaulted )
                        {
                            int updateRequestsCollectionIndex = updateRequestsList.IndexOf ( organizationRequestCollection );
                            foreach ( ExecuteMultipleResponseItem response in executeMultipleResponse.Responses )
                            {
                                int requestIndex = response.RequestIndex;
                                data.Find ( d => ( d.UpdateRequestsCollectionIndex == updateRequestsCollectionIndex ) && ( d.UpdateRequestIndex == requestIndex ) ).SetUpdateResponse ( response );
                            } 
                        }
                    }
                    catch ( Exception exception )
                    {
                        //TODO
                        //MessageBox.Show ( "Error occured while excecuting updates..." , "CSV Importer" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        LogError ( "Error occured while excecuting updates..." , exception );
                    }
                };

                w.ReportProgress ( 0 , "Excecuting updates..." );
                ParallelOptions parallelOptions = new ParallelOptions ( ) { MaxDegreeOfParallelism = context.MaxParallelism };
                Parallel.ForEach ( updateRequestsList , parallelOptions , executeMultipleAction );

                w.ReportProgress ( 0 , "Generating Report..." );
                ExportDataResultsToCSV ( data , context.FilePath );
            }
            )
            {
            } );
        }
        private void ExportDataResultsToCSV( List<DataLine> data , string filePath )
        {
            //TODO
            var reportFilePath = filePath.Insert ( filePath.LastIndexOf ( '.' ) , "-"+ DateTime.Now.ToFileTime ( ).ToString() + "-Report" );
            using ( var w = new StreamWriter ( reportFilePath ) )
            {
                foreach ( var item in data )
                {
                    w.WriteLine ( string.Format ( "{0};{1};{2};{3}" , item.LineNumber , "\"" + item.LineText + "\"" , item.IsOk , item.ErrorMessage ) );
                }
            }
        }
        #endregion

        private void tsbReset_Click( object sender , EventArgs e )
        {
            context.ColumnItems.Clear ( );
            GenerateTemplate ( );
        }

        private void tsbAbout_Click( object sender , EventArgs e )
        {
            var about = new About ()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            about.ShowDialog ( );
        }
    }
}