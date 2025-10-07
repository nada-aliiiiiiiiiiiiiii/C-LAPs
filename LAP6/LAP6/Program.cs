namespace LAP6
{
    internal class Program
    {
        public static void myfun(int x, int y)
        {
            try
            {
                Console.WriteLine(x / y);
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid format ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("invalid number ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Please enter number 1 :");
            bool z = int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Please enter number 2 :");
            bool f = int.TryParse(Console.ReadLine(), out y);

            if (z == true && f == true)
            {
                myfun(x, y);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            int[] arr ={10,40,23,45,74 };
            try
            {
                Console.WriteLine(arr[3]);

                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            using (X X1 = new X(10, 20))
            {

            }

        }
    }
}
