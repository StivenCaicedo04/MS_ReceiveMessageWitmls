namespace MS_ReceiveMessageWitmls.Utils
{
    public interface IXmlSerializerHelper
    {
        string SerializeToXml<T>(T data);
    }
}
