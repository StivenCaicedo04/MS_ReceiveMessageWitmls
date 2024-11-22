using MS_ReceiveMessageWitmls.Models.Response;

namespace MS_ReceiveMessageWitmls.Service
{
    public class WitsmlServerReceive : IWitsmlServerReceive
    {
        public string AddFromStore(string witsmlXml)
        {
            throw new NotImplementedException();
        }

        public string GetCap(string Request)
        {
            GetCapService service = new GetCapService();
            return service.GetCapInformation();
        }

        public string GetFromStore(string query)
        {
            throw new NotImplementedException();
        }

        public string GetVersion()
        {
            return "1.14.1.1";
        }
    }
}
