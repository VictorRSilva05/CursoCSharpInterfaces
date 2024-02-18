using System.Globalization;
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickUpDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime returnDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter price per hour: ");
            double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double perDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TimeSpan duration = returnDate - pickUpDate;

            string formatedDuration;

            if (duration > TimeSpan.FromHours(12))
            {
                if (duration > TimeSpan.FromDays(1))
                {
                    formatedDuration = duration.ToString(@"d\ hh:mm");
                    Console.WriteLine(formatedDuration);
                }
            }


            Console.WriteLine(duration);

          
        }
    }
}
