using System;
using System.Collections.Generic;
using System.Text;
using static Kurier.Shipment;

namespace Kurier
{

    public class Speedy : Courier
    {
        public Speedy() : base("Speedy") { }

        public override int CalculatePrice(Shipment s)
        {
            double price = s.Type switch
            {
                "Документи" => 4.00,
                "Стандартна" => 6.00,
                "Чуплива" => 9.00,
                "Експресна" => 12.00,
                _ => 0
            };

            if (s.Weight > 2)
                price += Math.Ceiling(s.Weight - 2) * 1.50;

            return price;
        }

        
    }

}
