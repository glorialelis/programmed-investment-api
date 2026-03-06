using System.Text.Json;
using Confluent.Kafka;

namespace CompraProgramada.Infrastructure.Messaging;

public class KafkaProducer
{
    private readonly IProducer<Null, string> _producer;

    public KafkaProducer()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        _producer = new ProducerBuilder<Null, string>(config).Build();
    }

    public async Task EnviarMensagem(string topic, object mensagem)
    {
        var json = JsonSerializer.Serialize(mensagem);

        await _producer.ProduceAsync(topic, new Message<Null, string>
        {
            Value = json
        });
    }
}