namespace Fletnix.Model
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int RunningTime { get; set; }
        public int AmountOfLikes { get; set; }
        public int AmountOfDislikes { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
