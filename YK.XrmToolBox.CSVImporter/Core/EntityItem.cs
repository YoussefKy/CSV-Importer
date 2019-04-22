using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YK.XrmToolBox.CSVImporter.Helpers;

namespace YK.XrmToolBox.CSVImporter.Core
{
    internal class EntityItem
    {
        private EntityMetadata _entityMetadata = null;
        private string _entityFriendlyName = "";

        public EntityMetadata EntityMetadata
        {
            get => _entityMetadata;
            private set => _entityMetadata = value;
        }

        public EntityItem(EntityMetadata entityMetadata)
        {
            EntityMetadata = entityMetadata;
        }

        public override string ToString()
        {
            if ( string.IsNullOrEmpty ( _entityFriendlyName ) )
            {
                _entityFriendlyName = MetadataHelper.GetFriendlyName ( _entityMetadata.DisplayName , _entityMetadata.LogicalName );
            }
            return _entityFriendlyName;
        }
    }
}
