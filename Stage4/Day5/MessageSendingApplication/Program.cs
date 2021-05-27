using Microsoft.Azure.ServiceBus;
using System;
using System.Text;

namespace MessageSendingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://g3buscheckmay.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=fU0YEuNWlTkqfnpIM1gneYut8UEu++dC5UVH4RVA2u4=";
            var queueName = "g3queue";
            var client = new QueueClient(connectionString, queueName);

            Console.WriteLine("Please enter a message");
            string userMessage = Console.ReadLine();
            client.SendAsync(new Message(UTF8Encoding.Unicode.GetBytes(userMessage)));
            Console.WriteLine("Message sent to bus");
            Console.ReadKey();
        }
    }
}
