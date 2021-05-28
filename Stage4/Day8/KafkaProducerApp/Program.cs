using System;
using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace KafkaProducerApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();
            int i = 1;
            while (true)
            {
                var message = new Message<Null, string>
                {
                    Value = "G3 sending message from app " + i
                };
                i++;
                var produceMessage = await producer.ProduceAsync("gayathrimsg_exchange", message);
                Console.WriteLine("The message sent is "+produceMessage.Value+" in the topic "+produceMessage.Topic);
                Thread.Sleep(1000);
            }
        }
    }
}
