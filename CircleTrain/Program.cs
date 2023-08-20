using CircleTrain.Model;

namespace CircleTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();

            train.ShowCarriagesInfo();
            Console.WriteLine();

            Console.WriteLine($"Количество вагонов в поезде: {train.GetNumberOfCarriages()}");

            Console.ReadKey();
        }
    }
}