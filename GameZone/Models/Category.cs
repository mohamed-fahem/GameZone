namespace GameZone.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        public virtual ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
