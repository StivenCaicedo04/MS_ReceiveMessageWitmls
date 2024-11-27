using Confluent.Kafka;

namespace MS_ReceiveMessageWitmls.Kafka
{
    public class KafkaProducerService
    {
        private readonly IConfiguration _configuration;
        private readonly ProducerConfig _producerConfig;

        public KafkaProducerService(IConfiguration configuration)
        {
            _configuration = configuration;
            _producerConfig = new ProducerConfig
            {
                BootstrapServers = _configuration["Kafka:BootstrapServers"]
            };
        }

        public async Task SendMessageAsync(string message)
        {
            using var producer = new ProducerBuilder<Null, string>(_producerConfig).Build();

            try
            {
                var result = await producer.ProduceAsync(
                    _configuration["Kafka:Topic"],
                    new Message<Null, string> { Value = message });

                Console.WriteLine($"Mensaje enviado a {result.TopicPartitionOffset}");
            }
            catch (ProduceException<Null, string> ex)
            {
                Console.WriteLine($"Error enviando mensaje: {ex.Error.Reason}");
            }
        }
    }
}
