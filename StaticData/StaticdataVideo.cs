using static KotaApi.Models.SendText;

namespace KotaApi.StaticData
{
    public static class StaticdataVideo
    {
        public static VmsData GetSendVideo()
        {
            return new VmsData
            {
                IpAdrress = "192.168.1.119",
                VMSScreenType = 8792,
                ScreenWidth = 256,
                ScreenHeight = 160,
                Port = 80,
                Username = "guest",
                Password = "guest",
                DeviceName = "KE/VMS/RGB/1.0/192.168.1.119",
                Subnetmask = "255.255.255.0",
                Gateway = "192.168.1.1",
                DnsServer = "192.168.1.1",
                DeviceCode = "032258230612003E3",
                Ip = "MTkyLjE2OC4xLjExOQ==",
                VMSMessageTypeId = 3,
                BrightnessValue = 255,
                MessagesData = new List<MessageData>
                {
                    new MessageData
                    {
                        SequenceNumber = 0,
                        ProgramName = "program_0",
                        FilePath = "8SP076ZEHK.mp4",
                        MessageDatas = "",
                        FontSize = 0,
                        FontFamily = "",
                        FontColor = "",
                        DisplayEffect = 16,
                        FontStyle = "",
                        DisplaySpeed = 1,
                        HorizontalAligment = "0",
                        VerticalAligment = "0",
                        MessageTypeId = 0,
                        StayTime = 0,
                        PositionX = 0,
                        PositionY = 0,
                        MessageDisplayWidth = 0,
                        MessageDisplayHeight = 0,
                        PlayModeId = 0,
                        PlayTime = 5000,
                        MessageStartDateTime = "",
                        MessageEndDateTime = "",
                        MessageAgainStartDateTime = "",
                        MessageAgainEndDateTime = "",
                        ScreenTransparency = 100,
                        DynamicArea = new DynamicArea { value = 0 },
                        DateTimeFormat = "%H:%M:%S",
                        MessageTypeName = "",
                        IsFtpFile = true
                    }
                }
            };
        }
    }
}
