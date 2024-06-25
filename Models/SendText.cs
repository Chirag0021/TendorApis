namespace KotaApi.Models
{
    public class SendText
    {
        public class VmsData
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
            public List<MessageData> MessagesData { get; set; }
        }

        public class MessageData
        {
            public int SequenceNumber { get; set; }
            public string ProgramName { get; set; }
            public string FilePath { get; set; }
            public string MessageDatas { get; set; }
            public int FontSize { get; set; }
            public string FontFamily { get; set; }
            public string FontColor { get; set; }
            public int DisplayEffect { get; set; }
            public string FontStyle { get; set; }
            public int DisplaySpeed { get; set; }
            public string HorizontalAligment { get; set; }
            public string VerticalAligment { get; set; }
            public int MessageTypeId { get; set; }
            public int StayTime { get; set; }
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public int MessageDisplayWidth { get; set; }
            public int MessageDisplayHeight { get; set; }
            public int PlayModeId { get; set; }
            public int PlayTime { get; set; }
            public string MessageStartDateTime { get; set; }
            public string MessageEndDateTime { get; set; }
            public string MessageAgainStartDateTime { get; set; }
            public string MessageAgainEndDateTime { get; set; }
            public int ScreenTransparency { get; set; }
            public DynamicArea DynamicArea { get; set; }
            public string DateTimeFormat { get; set; }
            public string MessageTypeName { get; set; }
            public bool IsFtpFile { get; set; }
        }

        public class DynamicArea
        {
            public int value { get; set; }
        }
    }
}
