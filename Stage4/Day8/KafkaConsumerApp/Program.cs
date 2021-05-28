using System;
using System.Threading;
using Confluent.Kafka;

namespace KafkaConsumerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                AutoOffsetReset= AutoOffsetReset.Earliest,
                GroupId ="g3-consumer-group"
            };
            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("gayathrimsg_exchange");
            var cancelToken = new CancellationTokenSource();
            Console.CancelKeyPress += (_, e) =>
            {
                e.Cancel = true;
                cancelToken.Cancel();
            };
            try
            {
                while (true)
                {
                    var consumeMessage = consumer.Consume(cancelToken.Token);
                    Console.WriteLine(consumeMessage.Value+"    "+consumeMessage.Topic);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                consumer.Close();
            }
            Console.ReadKey();
        }
    }
}
