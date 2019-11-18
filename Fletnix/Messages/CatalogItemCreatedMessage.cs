using Fletnix.Model;

namespace Fletnix.Messages
{
    public class CatalogItemCreatedMessage
    {
        public CatalogItem NewCatalogItem { get; set; }

        public CatalogItemCreatedMessage(CatalogItem newCatalogItem)
        {
            NewCatalogItem = newCatalogItem;
        }
    }
}
