using System;
using System.Collections.Generic;
using System.Text;

namespace Kurier
{
    public class Econt : Courier
    {
        public Econt() : base("Econt") { }

        public override int CalculatePrice(Shipment s)
        {
            double price = s.Type switch
            {
                "Документи" => 3.50,
                "Стандартна" => 6.50,
                "Чуплива" => 8.00,
                "Експресна" => 11.00,
                _ => 0
            };

            if (s.Weight > 3)
                price += Math.Ceiling(s.Weight - 3) * 2.00;

            return price;
        }

        
    }

}
