namespace GameZone.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
