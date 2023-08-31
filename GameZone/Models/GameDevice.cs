namespace GameZone.Models
{
    public class GameDevice
    {
        public int GameDeviceId { get; set; }

        public int GameId { get; set; }
        public Game Games { get; set; }

        public int DeviceId { get; set; }
        public Device Devices { get; set; }
    }
}
