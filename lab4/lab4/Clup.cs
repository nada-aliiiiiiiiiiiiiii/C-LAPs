using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public int depId { get; set; }

        public Club() { }


        public void AddEmp(Employee emp)
        {

            Employees.Add(emp);

        }
        public override string ToString()
        {
            return $"Club.Id={Id}, Club.Name={Name}";
        }

    }
}
