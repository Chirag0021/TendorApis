namespace KotaApi.Models
{
    public class SendAndSearchCommand
    {
        public string IpAdrress { get; set; }
        public int VMSScreenType { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DeviceName { get; set; }
        public string Subnetmask { get; set; }
        public string Gateway { get; set; }
        public string DnsServer { get; set; }
        public string DeviceCode { get; set; }
        public string Ip { get; set; }
        public int VMSMessageTypeId { get; set; }
        public int BrightnessValue { get; set; }
        public List<string> MessagesData { get; set; } = new List<string>();
    }
}
