using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YK.XrmToolBox.CSVImporter.Helpers
{
    internal class MetadataHelper
    {
        internal static List<EntityMetadata> RetrieveAllEntities( IOrganizationService service )
        {
            //List<>
            RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest ( )
            {
                EntityFilters = EntityFilters.Entity ,
                RetrieveAsIfPublished = true
            };

            // Retrieve the MetaData.
            RetrieveAllEntitiesResponse response = service.Execute ( request ) as RetrieveAllEntitiesResponse;
            return response.EntityMetadata.ToList ( );
        }

        internal static EntityMetadata RetriveAllEntityAttributes( IOrganizationService service , string entityLogicalName )
        {
            RetrieveEntityRequest request = new RetrieveEntityRequest
            {
                LogicalName = entityLogicalName ,
                EntityFilters = EntityFilters.Attributes
            };

            RetrieveEntityResponse response = ( RetrieveEntityResponse ) service.Execute ( request );

            return response.EntityMetadata;
        }

        internal static string GetFriendlyName( Label label , string logicalName )
        {
            string friendlyName = logicalName;
            if ( label.UserLocalizedLabel != null )
            {
                friendlyName = label.UserLocalizedLabel.Label;
            }
            else if ( label.LocalizedLabels.Count > 0 )
            {
                friendlyName = label.LocalizedLabels [ 0 ].Label;
            }
            return friendlyName;

        }

        internal static bool IsSupportedAttribute( AttributeMetadata item )
        {
            //AttributeTypeCode[] supportedTypes = new AttributeTypeCode[ AttributeTypeCode.String, ]
            List<AttributeTypeCode> supportedTypes = new List<AttributeTypeCode> ( )
            {
                AttributeTypeCode.String,
                AttributeTypeCode.Integer,
                AttributeTypeCode.Double,
                AttributeTypeCode.Decimal,
                AttributeTypeCode.BigInt,
                AttributeTypeCode.Memo,
            };

            if ( item.AttributeType != null && supportedTypes.Contains ( ( AttributeTypeCode ) item.AttributeType ) )
            {
                return true;
            }
            return false;
        }
    }
}
