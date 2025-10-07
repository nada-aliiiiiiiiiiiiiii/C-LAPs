using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        int apsentDays = 0;

        public Employee(int _id, string _name)
        {

            Id = _id;
            Name = _name;
        }
        public event Action<Employee> EmployeeFired;

        public void IncreaseApsentDays()
        {
            apsentDays++;
            if (apsentDays > 3)
            {
                EmployeeFired.Invoke(this);
            }
        }
        public override bool Equals(object? obj)
        {
            Employee emp = obj as Employee;
            if (emp == null) return false;
            if (this.GetType() != emp.GetType()) return false;
            return emp.Id == Id && emp.Name == Name;

        }
        public override string ToString()
        {
            return $"emp.Id =  {Id}  && emp.Name = {Name}";
        }
    }
}
