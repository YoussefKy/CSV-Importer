using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YK.XrmToolBox.CSVImporter.Helpers;

namespace YK.XrmToolBox.CSVImporter.Core
{
    internal class AttributeItem
    {
        private AttributeMetadata _attributeMetadata = null;
        private string _attributeFriendlyName = "";

        public AttributeMetadata AttributeMetadata
        {
            get => _attributeMetadata;
            private set => _attributeMetadata = value;
        }

        public AttributeItem(AttributeMetadata attributeMetadata)
        {
            AttributeMetadata = attributeMetadata;
        }

        public override string ToString()
        {
            if ( string.IsNullOrEmpty ( _attributeFriendlyName ) )
            {
                _attributeFriendlyName = MetadataHelper.GetFriendlyName ( _attributeMetadata.DisplayName , _attributeMetadata.LogicalName );
            }
            return _attributeFriendlyName;
        }
    }
}
