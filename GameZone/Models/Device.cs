namespace GameZone.Models
{
    public class Device
    {
        public int DeviceId { get; set; }

        public string DeviceName { get; set; }
        

        public virtual ICollection<GameDevice> Games { get; set; }
    }
}
