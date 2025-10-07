namespace lab4
{
    internal class Program
    {
        public static void Print(List<string> el)
        {
            foreach (string s in el)
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "nada", "ola", "soha", "Ahmed", "yasser" };
            var res1 = names.Findmylist(e => e.Length > 3);
            var re2 = names.Findmylist(e => e.StartsWith("a"));

            var re3 = names.Findmylist(e => e.EndsWith("a"));
            var re4 = names.Findmylist(e => e.Contains("a"));
            Print(res1);
            Console.WriteLine("======================================================");
            Print(re2);
            Console.WriteLine("======================================================");
            Print(re3);
            Console.WriteLine("======================================================");
            Print(re4);

            var ep1 = new Employee(1, "nada");
            var ep2 = new Employee(2, "nora");
            var c = new Club { Id = 10, Name = "iti" };

            var dep = new Department(100, ".net", c);
            var dep2 = new Department(200, "c#", c);



            dep.AddEmp(ep1);
            dep.AddEmp(ep2);




        }
    }
}
