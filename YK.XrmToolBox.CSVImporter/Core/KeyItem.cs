using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YK.XrmToolBox.CSVImporter.Helpers;

namespace YK.XrmToolBox.CSVImporter.Core
{
    internal class KeyItem
    {
        private string _entityKeyFriendlyName = "";

        public EntityKeyMetadata EntityKeyMetadata { get; private set; } = null;
        //public AttributeMetadata EntityPrimaryKeyMetadata { get; private set; } = null;

        public KeyItem( EntityKeyMetadata entityKeyMetadata )
        {
            EntityKeyMetadata = entityKeyMetadata;
        }

        //public KeyItem( AttributeMetadata attributeMetadata )
        //{
        //    EntityPrimaryKeyMetadata = attributeMetadata;
        //}

        public override string ToString()
        {
            if ( string.IsNullOrEmpty ( _entityKeyFriendlyName ) )
            {
                _entityKeyFriendlyName = MetadataHelper.GetFriendlyName ( EntityKeyMetadata.DisplayName, EntityKeyMetadata.LogicalName );
            }
            return _entityKeyFriendlyName;
        }
    }
}
