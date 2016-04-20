﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeText.Common.Messaging;

namespace WeText.Messaging.RabbitMq
{
    public class RabbitMqQueueCommandSender : RabbitMqQueueProducer, ICommandSender
    {
        public RabbitMqQueueCommandSender(string hostName, string queueName) : base(hostName, queueName)
        {
        }
    }
}
