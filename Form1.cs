using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Esercizio_chat_18_09_2023
{
    public partial class Form1 : Form
    {
        string jsonString;

        MqttClient mqttClient;
        public Form1()
        {
            InitializeComponent();
        }

        public class Messaggio
        {
            
            public string messaggio { get; set; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Messaggio messaggio1 = new Messaggio()
            {
                messaggio = "Michael: " + textBoxInvia.Text,
                
            };

            jsonString = JsonSerializer.Serialize(messaggio1);
            textBoxOutput.Text = jsonString;

            var factory = new MqttFactory();
            var mqttclient = factory.CreateMqttClient();
            
            var option = new MqttClientOptionsBuilder()
                .WithTcpServer("broker.hivemq.com", 1883)
                .Build();

            await mqttclient.ConnectAsync(option,CancellationToken.None);

            var message = new MqttApplicationMessageBuilder()
                .WithTopic("chat")
                .WithPayload(jsonString)
                .Build();

            await mqttclient.PublishAsync(message,CancellationToken.None);

            await mqttclient.DisconnectAsync(CancellationToken.None);   
        }
    }
}