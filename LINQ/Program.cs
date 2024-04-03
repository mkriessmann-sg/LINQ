namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] numbers = new int[30];
            
            for (int i = 0; i < (numbers.Length-1); i++) {

                numbers[i] = random.Next(1,100);

            }

            Console.WriteLine("Numbers:");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Numbers over 50:");
            IEnumerable<int> NumberQuery = 
                from number in numbers
                where number > 50
                orderby number descending
                select number;

           foreach (int i in NumberQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Numbers average:");
                double sum = numbers.Average();
            Console.WriteLine(sum);

            Console.WriteLine("Max Number:");
            int max = numbers.Max();
            Console.WriteLine(max);
            Console.WriteLine("Min Number:");
            int min = numbers.Min();
            Console.WriteLine(min);

        }
    }
}
