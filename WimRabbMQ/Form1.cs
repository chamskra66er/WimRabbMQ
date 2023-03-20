using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using WimRabbMQ.Support;

namespace WimRabbMQ
{
    public partial class Form1 : Form
    {
        private RabbitConnect Rabbit { get; set; }
        private IModel emailChanel;
        private IModel smsChanel;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Rabbit = RabbitConnect.GetInstatnce();
        }

        private void btnCreateExc_Click(object sender, EventArgs e)
        {
            using (var chanel = Rabbit.rabbitMQConnection.CreateModel())
            {
                chanel.ExchangeDeclare("CustomerNotification",ExchangeType.Direct, true,false);
            }
        }

        private void btnCreateQue_Click(object sender, EventArgs e)
        {
            using (var chanel = Rabbit.rabbitMQConnection.CreateModel())
            {
                chanel.QueueDeclare("Email", true, false,false);
                chanel.QueueDeclare("SMS", true, false, false);
            }
        }

        private void btnBindQue_Click(object sender, EventArgs e)
        {
            using (var chanel = Rabbit.rabbitMQConnection.CreateModel())
            {
                chanel.QueueBind("Email", "CustomerNotification", "email");
                chanel.QueueBind("SMS", "CustomerNotification", "sms");
            }

            SubscribeEmailQueues();
        }

        private void btnPubEm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text))
            {
                using (var chanel = Rabbit.rabbitMQConnection.CreateModel())
                {
                    var properties = chanel.CreateBasicProperties();
                    properties.DeliveryMode = 2;
                    chanel.BasicPublish("CustomerNotification", "email",
                        properties, Encoding.UTF8.GetBytes(tbEmail.Text));
                }
            }
        }

        private void SubscribeEmailQueues()
        { 
            emailChanel = Rabbit.rabbitMQConnection.CreateModel();
            emailChanel.BasicQos(0,1,false);

            var emailChanelConsumer = new AsyncEventingBasicConsumer(emailChanel);
            emailChanelConsumer.Received += EmailChanelConsumer_Received;
            emailChanel.BasicConsume("Email", false, emailChanelConsumer);
        }

        private async Task EmailChanelConsumer_Received(object sender, BasicDeliverEventArgs e)
        {
            //так как требуется коллбек на полученное сообщение, у данного канала стоит подтверждение получения
            await Task.Delay(TimeSpan.FromSeconds(8));

            var message = Encoding.UTF8.GetString(e.Body.ToArray());
            textBox1.Invoke((MethodInvoker)(() => textBox1.Text += "\r\n"+message));

            await Task.Delay(TimeSpan.FromSeconds(3));
            emailChanel.BasicAck(e.DeliveryTag, false);


        }
    }
}