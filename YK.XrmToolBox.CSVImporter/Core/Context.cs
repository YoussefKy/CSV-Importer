using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk.Metadata;

namespace YK.XrmToolBox.CSVImporter.Core
{
    internal class Context
    {

        public Context()
        {
            ColumnItems = new BindingList<ColumnItem> ( );
        }

        public int MaxParallelism
        {
            get;
            internal set;
        }
        public int Unicity
        {
            get;
            internal set;
        }
        public string FilePath
        {
            get;
            internal set;
        }
        public bool IsKeyDetected
        {
            get;
            internal set;
        }
        public ColumnTypeCode QueryType
        {
            get;
            internal set;
        }
        internal AttributeMetadata [ ] EntityAttributes
        {
            get;set;
        }
        internal int BatchSize
        {
            get;set;
        }
        internal EntityItem EntityItem
        {
            get;set;
        }
        internal BindingList<ColumnItem> ColumnItems
        {
            get;
            set;
        }
    }
}
