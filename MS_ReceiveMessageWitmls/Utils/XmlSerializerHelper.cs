using System.Text;
using System.Xml.Serialization;

namespace MS_ReceiveMessageWitmls.Utils
{
    public class XmlSerializerHelper
    {
        /// <summary>
        /// Serializa un objeto genérico a un XML como cadena.
        /// </summary>
        /// <typeparam name="T">El tipo del objeto a serializar.</typeparam>
        /// <param name="data">El objeto a serializar.</param>
        /// <returns>Una cadena XML que representa el objeto.</returns>
        public static string SerializeToXml<T>(T data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data), "El objeto a serializar no puede ser nulo.");

            var serializer = new XmlSerializer(typeof(T));

            using var stringWriter = new StringWriterWithEncoding(Encoding.UTF8);

            serializer.Serialize(stringWriter, data);

            return stringWriter.ToString();
        }
    }

    /// <summary>
    /// Clase auxiliar para manejar la codificación de salida al serializar.
    /// </summary>
    public class StringWriterWithEncoding : StringWriter
    {
        private readonly Encoding _encoding;

        public StringWriterWithEncoding(Encoding encoding)
        {
            _encoding = encoding;
        }

        public override Encoding Encoding => _encoding;
    }
}
