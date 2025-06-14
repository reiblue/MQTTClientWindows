﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using System;
using System.Text;
using System.Threading.Tasks;

namespace MQTTClient
{
    public class MqttPublisher
    {
        private readonly IMqttClient _mqttClient;
        private readonly MqttClientOptions _options;

        public MqttPublisher(string brokerAddress, int brokerPort = 1883)
        {
            var factory = new MqttFactory();
            _mqttClient = factory.CreateMqttClient();

            _options = new MqttClientOptionsBuilder()
                .WithTcpServer(brokerAddress, brokerPort)
                .WithCleanSession()
                .Build();
        }

        public async Task ConnectAsync()
        {
            try
            {
                await _mqttClient.ConnectAsync(_options);
                Console.WriteLine("Conectado ao broker MQTT!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task PublishAsync(string topic, string payload)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(Encoding.UTF8.GetBytes(payload))
                .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce) // QoS 1
                .WithRetainFlag(false)
                .Build();

            if (_mqttClient.IsConnected)
            {
                await _mqttClient.PublishAsync(message);
                Console.WriteLine($"Mensagem publicada no tópico '{topic}': {payload}");
            }
            else
            {
                Console.WriteLine("Não está conectado ao broker!");
            }
        }

        public async Task DisconnectAsync()
        {
            await _mqttClient.DisconnectAsync();
            Console.WriteLine("Desconectado do broker.");
        }
    }
}
