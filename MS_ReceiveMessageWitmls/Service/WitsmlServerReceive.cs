using MS_ReceiveMessageWitmls.Kafka;
using MS_ReceiveMessageWitmls.Service.Interfaces;

namespace MS_ReceiveMessageWitmls.Service
{
    public class WitsmlServerReceive : IWitsmlServerReceive
    {
        private readonly IGetCapService _getCapService;
        private readonly IGetFromStoreService _getFromStoreService;
        private readonly KafkaProducerService _kafkaProducerService;

        public WitsmlServerReceive(IGetCapService getCapService, IGetFromStoreService getFromStoreService, KafkaProducerService kafkaProducerService)
        {
            _getCapService = getCapService;
            _getFromStoreService = getFromStoreService;
            _kafkaProducerService = kafkaProducerService;
        }
        public string AddFromStore(string witsmlXml)
        {
            var result = _kafkaProducerService.SendMessageAsync(witsmlXml);
            string response = "OK - 200";
            return response;
        }

        public string GetCap(string Request)
        {
            return _getCapService.GetCapInformation();
        }

        public string GetFromStore(string query)
        {
            return _getFromStoreService.GetFromStore(query);
        }

        public string GetVersion()
        {
            return "1.14.1.1";
        }
    }
}
