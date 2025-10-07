namespace lab3
{
    internal class Program
    {
        delegate int Del1(int x, int y);
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int multibly(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Del1 mydel = new Del1(Add);
            int z = mydel.Invoke(10, 20);
            Console.WriteLine(z);
            Console.WriteLine("=============================================");

            Del1 mydel2 = delegate (int x, int y)
            {
                return x + y;
            };
            z += mydel2.Invoke(10, 20);
            Console.WriteLine(z);

            Console.WriteLine("=============================================");
            Func<int> del3 = () => 10 + 30;
            Console.WriteLine(del3());

            Console.WriteLine("=============================================");

            Del1 multi = new Del1(multibly);
            int x = multi.Invoke(10, 20);
            Console.WriteLine(x);


            Del1 sub = (a, b) => { return a - b; };
            int y = sub.Invoke(10, 20);
            Console.WriteLine(y);


            Console.WriteLine("===========================================");
            Action print = () => Console.WriteLine("Action is a delegate");

            Console.WriteLine("===========================================");
            Predicate<int> sum = x => x > 10;
            Console.WriteLine(sum(12));



            Console.WriteLine("================================================================================================");

            MyList<int> numbers = new MyList<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            numbers.Print();   

            numbers.Remove(20);
            numbers.Print();  



        }
    }
}
