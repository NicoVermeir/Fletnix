using Fletnix.Model;

namespace Fletnix.Messages
{
    public class CatalogItemDetailsMessage
    {
        public CatalogItem CatalogItem { get; set; }

        public CatalogItemDetailsMessage(CatalogItem catalogItem)
        {
            CatalogItem = catalogItem;
        }
    }
}
