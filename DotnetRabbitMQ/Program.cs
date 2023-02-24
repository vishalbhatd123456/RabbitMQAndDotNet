using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace DotnetRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //here we create a publisher
            //create a connection factory
            var factory = new ConnectionFactory
            {
                Uri = new Uri("amqp://guest:guest@localhost:5672")
            };

            //create a connection
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("Test-Queue", true, false, false, null);
            //publish a message to queue
            var message = new { Name = "Producer", Message = "Hello" };
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

            channel.BasicPublish("", "demo-queue", null, body);
        }
    }
}

