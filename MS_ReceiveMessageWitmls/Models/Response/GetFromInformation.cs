using System.Xml.Serialization;

namespace MS_ReceiveMessageWitmls.Models.Response
{
    public class GetFromInformation
    {
        [XmlRoot("witsml")]
        public class Witsml
        {
            [XmlAttribute("version")]
            public string Version { get; set; } = "1.4.1.1";

            [XmlElement("logs")]
            public Logs? Logs { get; set; }
        }

        public class Logs
        {
            [XmlElement("log")]
            public List<Log> LogList { get; set; } = new();
        }

        public class Log
        {
            [XmlAttribute("uidWell")]
            public string UidWell { get; set; }

            [XmlAttribute("uid")]
            public string Uid { get; set; }

            [XmlElement("nameWell")]
            public string NameWell { get; set; }

            [XmlElement("name")]
            public string Name { get; set; }

            [XmlElement("serviceCompany")]
            public string ServiceCompany { get; set; }

            [XmlElement("logCurveInfo")]
            public List<LogCurveInfo> LogCurveInfoList { get; set; } = new();

            [XmlElement("logData")]
            public List<LogData> LogDataList { get; set; } = new();
        }

        public class LogCurveInfo
        {
            [XmlAttribute("uid")]
            public string Uid { get; set; }

            [XmlElement("mnemonic")]
            public string Mnemonic { get; set; }

            [XmlElement("unit")]
            public string Unit { get; set; }

            [XmlElement("typeLogData")]
            public string TypeLogData { get; set; }
        }

        public class LogData
        {
            [XmlElement("data")]
            public string Data { get; set; }
        }

    }
}
