namespace HW4;

class Program
{
    static void Main(string[] args)
    {
        CarRental carRental = new CarRental("Giorgos", "Balatzis", 365);
        Console.WriteLine(carRental.ToString());
        
        CarRental carRental1 = new CarRental("Borgos", "Gialatzis", 563);
        Console.WriteLine(carRental1.ToString());
    }
}