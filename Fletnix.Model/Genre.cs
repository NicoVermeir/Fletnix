using System.Collections.Generic;

namespace Fletnix.Model
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CatalogItem> CatalogItems { get; set; }
    }
}
