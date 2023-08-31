namespace GameZone.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }

        public string Cover { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public virtual ICollection<GameDevice> Devices { get; set; }
    }
}
