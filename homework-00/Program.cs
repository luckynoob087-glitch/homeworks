namespace homework_00
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                ArrayHelper helper = new ArrayHelper();

                int[] numbers = { 10, 20, 30, 40, 50 };
                string[] names = { "Nino", "Giorgi", "Ana" };

                Console.WriteLine("Reverse:");
                helper.PrintReverse(numbers);

                Console.WriteLine("First: " + helper.GetFirstElement(numbers));
                Console.WriteLine("Last: " + helper.GetLastElement(names));
                Console.WriteLine("Contains 30: " + helper.ContainsElement(numbers, 30));
                Console.WriteLine("Contains 99: " + helper.ContainsElement(numbers, 99));
                Console.WriteLine("Count: " + helper.CountElements(names));
                Console.WriteLine("Index of Giorgi: " + helper.FindIndex(names, "Giorgi"));
                Console.WriteLine("Index of Lasha: " + helper.FindIndex(names, "Lasha"));

                Console.ReadLine();
            }
        }
    }

