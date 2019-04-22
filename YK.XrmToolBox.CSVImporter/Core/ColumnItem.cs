using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YK.XrmToolBox.CSVImporter.Core
{
    internal class ColumnItem : DataGridViewRow
    {
        private AttributeTypeCode? _attributeTypeCode = null;
        private string _logicalName = "";

        public ColumnItem( ColumnTypeCode attributeToUpdate , EntityItem entityItem , AttributeItem attributeItem )
        {
            ColumnType = attributeToUpdate;
            EntityItem = entityItem;
            AttributeItem = attributeItem;
        }

        public ColumnItem( ColumnTypeCode columnType , EntityItem entityItem , AttributeItem attributeItem , ConditionOperator conditionOperator )
        {
            ColumnType = columnType;
            EntityItem = entityItem;
            AttributeItem = attributeItem;
            ConditionOperatorCode = conditionOperator;
        }

        public ColumnTypeCode ColumnType
        {
            get; set;
        }
        public EntityItem EntityItem
        {
            get; set;
        }
        public AttributeItem AttributeItem
        {
            get; set;
        }
        //[System.ComponentModel.Browsable ( false )]
        public string LogicalName
        {
            get
            {
                if ( string.IsNullOrEmpty ( _logicalName ) )
                {
                    _logicalName = AttributeItem.AttributeMetadata.LogicalName;
                }
                return _logicalName;
            }
            set => _logicalName = value;
        }
        public ConditionOperator ConditionOperatorCode
        {
            get; set;
        }
        public AttributeTypeCode? AttributeTypeCode
        {
            get
            {
                if ( _attributeTypeCode == null )
                {
                    _attributeTypeCode = AttributeItem.AttributeMetadata.AttributeType;
                }
                return _attributeTypeCode;
            }
            set => _attributeTypeCode = value;
        }
    }
}
