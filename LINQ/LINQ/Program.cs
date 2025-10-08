using LINQ;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ
{
    internal class Program
    {

        static void Main(string[] args)
        {



            //----------------------------1-----------------------
            var re1 = ListGenerators.ProductList.Where(x => x.UnitsInStock == 0);
            foreach (var x in re1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------------------");

            //----------------------------2------------------------- 
            var re2 = ListGenerators.ProductList.Where(x => x.UnitsInStock >= 1 && x.UnitPrice > 3);
            foreach (var x in re2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------------------");

            //--------------------------------------3---------------------------
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            //------------------------1-------------------------  
            var re4 = ListGenerators.ProductList.FirstOrDefault(x => x.UnitsInStock == 0);
            Console.WriteLine(re4);
            Console.WriteLine("---------------------------");

            //-------------------------2-----------------------------------------
            var re5 = ListGenerators.ProductList.FirstOrDefault(x => x.UnitPrice > 1000);
            Console.WriteLine(re5);
            Console.WriteLine("---------------------------");


            //--------------------------------------3---------------------------
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var re6 = Arr2.Skip(1).FirstOrDefault(x => x > 5);

            Console.WriteLine(re6);
            Console.WriteLine("---------------------------");


            //--------------------------------------1---------------------------
            var re0 = ListGenerators.ProductList.DistinctBy(x => x.ProductName);
            Console.WriteLine(re0);
            Console.WriteLine("---------------------------");

            //--------------------------------------2---------------------------
            var re7 = ListGenerators.ProductList.Select(p => p.ProductName[0])
            .Union(ListGenerators.CustomerList.Select(c => c.CompanyName[0]));

            foreach (var x in re7)
            {
                Console.WriteLine(x);
            }

            //--------------------------------------3---------------------------

            var re8 = ListGenerators.ProductList.Select(p => p.ProductName[0])
            .Intersect(ListGenerators.CustomerList.Select(c => c.CompanyName[0]));
            foreach (var x in re8)
            {
                Console.WriteLine(x);
            }

            //--------------------------------------4---------------------------

            var re9 = ListGenerators.ProductList.Select(p => p.ProductName[0])
            .Except(ListGenerators.CustomerList.Select(c => c.CompanyName[0]));

            foreach (var x in re9)
            {
                Console.WriteLine(x);
            }
            //--------------------------------------5---------------------------


            

            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int re11 = Arr3.Count(n => n % 2 != 0);

            Console.WriteLine(re11);
            Console.WriteLine("------------------------");


            //--------------------------------------2---------------------------
            var re12 = ListGenerators.CustomerList

           .Select(c => new { c.CompanyName, OrdersCount = c.Orders.Count() });
            Console.WriteLine(re12);
            Console.WriteLine("------------------------");


            var re13 = ListGenerators.ProductList
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, ProductCount = g.Count() });


            int total = Arr3.Sum();

            Console.WriteLine(total);
            Console.WriteLine("------------------------");

            //------------------------Get the total number of characters of all words ---------------------------
            var re14 = File.ReadAllLines("dictionary_english.txt");

            int totalCh= re14.Sum(w => w.Length);
             Console.WriteLine(totalCh);
            //------------------Get the total units in stock ---------------------------.
            var re15 = ListGenerators.ProductList
            .GroupBy(p => p.Category)
            .Select(g => new {
                Category = g.Key,
                TotalUnits = g.Sum(p => p.UnitsInStock)
            });
            foreach (var x in re15)
            {
                Console.WriteLine(x);
            }

            //--------------------------------------7---------------------------
            int shortest = re14.Min(w => w.Length);
            Console.WriteLine(shortest);

            //--------------------------------------8---------------------------
            var re16 = ListGenerators.ProductList.GroupBy(p => p.Category)
           .Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) });


            //-----------------------------Get the length of the longest word --------------------
            int longest = re14.Max(w => w.Length);
            Console.WriteLine(longest);
            //-------------------- Get the most expensive price ----------------
            var re17 = ListGenerators.ProductList.GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });



            //--------------------------------------13---------------------------
            double avgLength = re14.Average(w => w.Length);




            //--------------------------------------14---------------------------
            var re18 = ListGenerators.ProductList.GroupBy(p => p.Category)
           .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });
            Console.WriteLine(re18);

            //--------------------------------------1---------------------------
            var sort = ListGenerators.ProductList
             .OrderBy(p => p.ProductName);
            foreach (var x in sort)
            {
                Console.WriteLine(x);
            }


            string[] Arr4= { "Orange", "apple", "Mango", "banana", "KiWi", "grape", "WATERMELON", "pear", "Apricot" };
            //--------------------------------------2---------------------------
            var re19 = Arr4.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);
            foreach (var x in re19)
            {
                Console.WriteLine(x);
            }
            // ------------------------Sort a list of products by units ---------------------------------------------
            var RE20 = ListGenerators.ProductList
              .OrderByDescending(p => p.UnitsInStock);
            foreach (var x in RE20)
            {
                Console.WriteLine(x);
            }

            // --------------------------Sort a list of digits --------------------------------
            // 
            string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var re21 = Arr5.OrderBy(d => d.Length).ThenBy(d => d);


            // ---------------Sort by word length and case-insensitive sort of the words in an array. 
            string[] words = { "Orange", "apple", "Mango", "banana", "KiWi", "grape", "WATERMELON", "pear", "Apricot" };
            var re22 = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            foreach (var x in re22)
            {
                Console.WriteLine(x);
            }


            // Sort a list of products, first by category, and then by unit price, from highest to lowest. 
            var re23 = ListGenerators.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            foreach (var x in re23)
            {
                Console.WriteLine(x);
            }

            // Sort  by word length and then by a case-insensitive descending 
            string[] Arr6 = { "Orange", "apple", "Mango", "banana", "KiWi", "grape", "WATERMELON", "pear", "Apricot" };
            var re24 = Arr6.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var x in re24)
            {
                Console.WriteLine(x);
            }


            string[] Arr7 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var reversed = Arr7.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            foreach (var x in reversed)
            {
                Console.WriteLine(x);
            }











        }
    }
}
