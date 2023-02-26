using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

using M2Mqtt;
using M2Mqtt.Messages;

namespace Tools
{
    public class AWS_MQTT_Client
    {
        public string iotEndpoint = "a3go886l5i56ev-ats.iot.ap-northeast-1.amazonaws.com";
        public int brokerPort = 8883;
        public string topic = "$aws/things/My_Virtual_Device/shadow/name/My_Virtual_Device_Shadow/update/accepted";
        public string Received_Message = "";
        public bool connected = false;
        public bool subscribed=false;
        MqttClient client;
        public string value="";
        string jsonState;
        public int test_val = 0;
        public string password = "MyDevice123";

        public AWS_MQTT_Client()
        {
           
        }

        public void connect()
        {
            try
            {
                var caCert = X509Certificate.CreateFromCertFile(Path.Join(AppContext.BaseDirectory, "AmazonRootCA1.pem"));
                var clientCert = new X509Certificate2(Path.Join(AppContext.BaseDirectory, "device_certificate.cert.pfx"), password);

                client = new MqttClient(iotEndpoint, brokerPort, true, caCert, clientCert, MqttSslProtocols.TLSv1_2);

                client.MqttMsgSubscribed += IotClient_MqttMsgSubscribed;
                client.MqttMsgPublishReceived += IotClient_MqttMsgPublishReceived;

                string clientId = Guid.NewGuid().ToString();
                client.Connect(clientId);
                client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                connected= true;
            }
            catch(Exception ex)
            {
                connected = false;
                subscribed= false;
            }
        }

        private  void IotClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Received_Message=Encoding.UTF8.GetString(e.Message);
        }

        private  void IotClient_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            subscribed= true;
        }

        public void send()
        {
            jsonState = "{\"state\":{\"desired\":{\"command\":\""+value+"\"}}}";

            if (connected)
            {
                byte[] Payload = Encoding.UTF8.GetBytes(jsonState);
                client.Publish(topic, Payload);
            }
        }

        public void send(string data)
        {
            jsonState = "{\"state\":{\"desired\":{\"command\":\""+data+"\"}}}";

            if (connected)
            {
                byte[] Payload = Encoding.UTF8.GetBytes(jsonState);
                client.Publish(topic, Payload);
            }
        }

        public void test()
        {
            jsonState = "{\"state\":{\"desired\":{\"command\":\""+test_val.ToString()+"\"}}}";

            if (connected)
            {
                byte[] Payload = Encoding.UTF8.GetBytes(jsonState);
                client.Publish(topic, Payload);
                test_val++;
            }
        }






















    }
}
