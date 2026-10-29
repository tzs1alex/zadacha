using System;
using System.Collections.Generic;
using System.Text;

namespace Kurier
{
    internal class BoxNow : Courier
    {
        public BoxNow() : base("BoxNow") { }

        public override int CalculatePrice(Shipment s)
        {
            double price = s.Type switch
            {
                "Документи" => 3,
                "Стандартна" => 5,
                "Чуплива" => 7.00,
                "Експресна" => 11,
                _ => 0
            };

            if (s.Weight > 3)
                price += Math.Ceiling(s.Weight - 3) * 2.00;

            return price;
        }
    }
}
