using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WimRabbMQ.Support
{
    public class RabbitConnect
    {
        private readonly string connectionString;
        private readonly ConnectionFactory connectionFactory;
        public readonly IConnection rabbitMQConnection;

        private static RabbitConnect rabbitConnect;

        public RabbitConnect()
        { 
            connectionString = ConfigurationManager.ConnectionStrings["RabbitMqConnection"].ConnectionString;
            connectionFactory = new ConnectionFactory();
            connectionFactory.Uri = new Uri(connectionString);
            connectionFactory.AutomaticRecoveryEnabled = true;
            connectionFactory.DispatchConsumersAsync = true;
            rabbitMQConnection = connectionFactory.CreateConnection("DemoAppClient");
        }
        public static RabbitConnect GetInstatnce()
        {
            if (rabbitConnect == null)
                rabbitConnect = new RabbitConnect();
            return rabbitConnect;
        }
    }
}
