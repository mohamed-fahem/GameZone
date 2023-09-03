namespace GameZone.Models
{
    public class Device
    {
        public int DeviceId { get; set; }

        public string DeviceName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Icon { get; set; } = string.Empty;

    }
}
