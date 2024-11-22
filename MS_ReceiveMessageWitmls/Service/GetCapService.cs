using MS_ReceiveMessageWitmls.Models.Response;
using MS_ReceiveMessageWitmls.Utils;

namespace MS_ReceiveMessageWitmls.Service
{
    public class GetCapService
    {
        public string GetCapInformation()
        {
            XmlSerializerHelper serializerHelper = new XmlSerializerHelper();

            var capServer = new GetCapInformation
            {
                Version = "1.4.1.1",
                ServerName = "IKM WITSML Server",
                Contact = "support@example.com",
                Description = "WITSML server for well and log data",
                Funtions = new List<string> { "GetVersion", "GetCap", "GetFromStore", "AddFromStore" }
            };

            var xmlResponse = serializerHelper.SerializeToXml(capServer);
            return xmlResponse;
        }
    }
}
