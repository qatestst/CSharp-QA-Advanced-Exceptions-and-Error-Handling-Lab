namespace _01._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            try
            {
                if (num < 0)
                {
                    throw new Exception();
                }

                double sqrt = Math.Sqrt(num);
                Console.WriteLine(sqrt);
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}