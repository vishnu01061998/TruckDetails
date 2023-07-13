namespace TruckDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truck obj = new Truck();
            obj.GetTruckDetails();
            obj.GetTruckDetails("Delivery will be after 30 days", 7.8, 120, true, "AshokLeyland", 10, true);
            Console.ReadLine();

        }
    }
    public class Truck
    {
        public string Title { get; set; } = string.Empty;

        public double version { get; set; }
        public int Speed { get; set; }
        public bool DeliveryAvailable { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public byte Gear { get; set; }
        public bool Deisel { get; set; }

        public void GetTruckDetails()
        {
            Title = "Delivery Avalible for Truck";
            version = 7.8;
            Speed = 120;
            DeliveryAvailable = true;
            CompanyName = "Ashokleyland";
            Gear = 10;
            Deisel = true;

            Console.WriteLine(Title);
            Console.WriteLine(version);
            Console.WriteLine(Speed);
            Console.WriteLine(DeliveryAvailable);
            Console.WriteLine(CompanyName);
            Console.WriteLine(Gear);
            Console.WriteLine(Deisel);

        }

        public void GetTruckDetails(string title, double version, int speed, bool DeliverAvalible, string companyName, byte Gear, bool diesel)
        {
            Title = "Delivery Avalible for Truck";
            version = 7.8;
            Speed = 120;
            DeliveryAvailable = true;
            CompanyName = "Ashokleyland";
            Gear = 10;
            Deisel = true;


            Console.WriteLine(Title);
            Console.WriteLine(version);
            Console.WriteLine(Speed);
            Console.WriteLine(DeliveryAvailable);
            Console.WriteLine(CompanyName);
            Console.WriteLine(Gear);
            Console.WriteLine(Deisel);

        }



    }

}