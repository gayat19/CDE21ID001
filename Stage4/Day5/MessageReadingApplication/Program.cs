using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace MessageReadingApplication
{
    class Program
    {
       
        static IQueueClient queueclient;
        static void RegisterHandlerOnMessage()
        {
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false

            };
            queueclient.RegisterMessageHandler(ProcessMessageAsync, messageHandlerOptions);
        }
        static async Task ProcessMessageAsync(Message message, CancellationToken token)
        {
            Console.WriteLine("Message comming through.....");
            Console.WriteLine(Encoding.UTF8.GetString(message.Body));
            await queueclient.CompleteAsync(message.SystemProperties.LockToken);
        }
        static Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            Console.WriteLine("Could not proceess the read ");
            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            Console.WriteLine("End Point "+context.Endpoint);
            Console.WriteLine($"Execting action {context.Action}");
            Console.WriteLine( );
            return Task.CompletedTask;
        }
        static async Task MainAsync()
        {
            const string  connectionString = "Endpoint=sb://g3buscheckmay.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=fU0YEuNWlTkqfnpIM1gneYut8UEu++dC5UVH4RVA2u4=";
            const string QueueName = "g3queue";
            queueclient = new QueueClient(connectionString,QueueName);
            Console.WriteLine("Reading Messages");
            RegisterHandlerOnMessage();
            Console.ReadKey();
            await queueclient.CloseAsync();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            MainAsync().GetAwaiter().GetResult();
        }
    }
}
