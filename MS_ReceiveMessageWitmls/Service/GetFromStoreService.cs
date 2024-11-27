using MS_ReceiveMessageWitmls.Service.Interfaces;
using MS_ReceiveMessageWitmls.Utils;
using static MS_ReceiveMessageWitmls.Models.Response.GetFromInformation;

namespace MS_ReceiveMessageWitmls.Service
{
    public class GetFromStoreService : IGetFromStoreService
    {
        private readonly IXmlSerializerHelper _xmlSerializerHelper;
        public GetFromStoreService(IXmlSerializerHelper xmlSerializerHelper)
        {
            _xmlSerializerHelper = xmlSerializerHelper;
        }
        public string GetFromStore(string request)
        {
            var witsml = new Witsml
            {
                Logs = new Logs
                {
                    LogList = new()
                    {
                        new Log
                        {
                            UidWell = "1234",
                            Uid = "5678",
                            NameWell = "Example Well",
                            Name = "Gamma Ray Log",
                            ServiceCompany = "Company XYZ",
                            LogCurveInfoList = new()
                            {
                                new LogCurveInfo
                                {
                                    Uid = "GR",
                                    Mnemonic = "GR",
                                    Unit = "API",
                                    TypeLogData = "double"
                                }
                            },
                            LogDataList = new()
                            {
                                new LogData { Data = "100.0,55.3" },
                                new LogData { Data = "101.0,54.8" },
                                new LogData { Data = "102.0,56.1" }
                            }
                        }
                    }
                }
            };

            return _xmlSerializerHelper.SerializeToXml(witsml);
        }
    }
}
