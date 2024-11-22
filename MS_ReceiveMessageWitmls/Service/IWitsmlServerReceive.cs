﻿using System.ServiceModel;

namespace MS_ReceiveMessageWitmls.Service
{
    public interface IWitsmlServerReceive
    {
        [OperationContract]
        string GetVersion();

        [OperationContract]
        string GetCap(string capabilitiesRequest);

        [OperationContract]
        string GetFromStore(string query);

        [OperationContract]
        string AddFromStore(string witsmlXml);
    }
}
