using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }

        Club club;


        public Department(int _id, string _name, Club _c)
        {

            Id = _id; Name = _name; club = _c;
        }

        public void AddEmp(Employee employee)
        {

            employees.Add(employee);
            club.AddEmp(employee);

            employee.EmployeeFired += RemoveEmp;
        }
        public void RemoveEmp(Employee employee)
        {
            employees.Remove(employee);
        }

        public override bool Equals(object? obj)
        {
            Department dep = obj as Department;
            if (dep == null) return false;
            if (this.GetType() != dep.GetType()) return false;
            return dep.Id == Id && dep.Name == Name;

        }
        public override string ToString()
        {
            return $"dep.Id =  {Id}  && dep.Name = {Name} ";
        }

    }
}
