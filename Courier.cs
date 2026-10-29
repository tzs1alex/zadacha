using System;
using System.Collections.Generic;
using System.Text;

namespace Kurier
{
    internal class Courier
    {
        public string Name { get; set; }
        public List<Shipment> Shipments = new List<Shipment>();
        public Courier(string name)
        {
            this.Name = name;
        }
        
      
        public void SendShipment(Shipment shipment)
        {
            Shipments.Add(shipment);

            Console.WriteLine($"Куриерска фирма: {Name}");
            Console.WriteLine($"Подател: {shipment.Sender}");
            Console.WriteLine($"Получател: {shipment.Receiver}");
            Console.WriteLine($"Вид пратка: {shipment.Type}");
            Console.WriteLine($"Тегло: {shipment.Weight} кг");
            Console.WriteLine($"Цена:{CalculatePrice(shipment)}");
            Console.WriteLine("Пратката е изпратена успешно!");
            Console.WriteLine();
        }
        public virtual int CalculatePrice(Shipment shipment)
        {
            return 0;
        }

        
    }
}
