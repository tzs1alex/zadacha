namespace Kurier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Courier> couriers = new List<Courier>
        {
            new Speedy(),
            new Econt(),
            new BoxNow(),

        };

            Shipment s1 = new Shipment(
                "Даниел А", "Мария И", 4, "Стандартна");

            Shipment s2 = new Shipment(
                "Георги А", "Петър Г", 1, "Документи");

            Shipment s3 = new Shipment(
                "Антон Б", "Валери Б", 5.5, "Чуплива");

            couriers[0].SendShipment(s1);
            couriers[1].SendShipment(s2);
            couriers[2].SendShipment(s3);

            Console.WriteLine("ИНФОРМАЦИЯ ЗА КУРИЕРИТЕ:");

            foreach (Courier courier in couriers)
            {
                
                Console.WriteLine();
            }
        }

    }
    
}
