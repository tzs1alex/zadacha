using System;
using System.Collections.Generic;
using System.Text;

namespace Kurier
{

    public class Shipment
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }

        public Shipment(string sender, string receiver, double weight, string type)
        {
            Sender = sender;
            Receiver = receiver;
            Weight = weight;
            Type = type;
        }
    }

}
