using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC
{
    internal class Employee :IComparable
    {
        public Employee() { }
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id {  get; set; }
        public string Name { get; set; }
        public double Salary {  get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }


        public override bool Equals(object? obj)
        {
            Employee employee= (Employee?)obj;
            return (this.Id == employee?.Id) && (this.Name == employee?.Name) && (this.Salary == employee?.Salary);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id.GetHashCode(), Name.GetHashCode(), Salary.GetHashCode());
        }

        public int CompareTo(object? obj)
        {
            Employee? employee = obj as Employee;
            return this.Salary.CompareTo(employee?.Salary);

        }



        //public static bool operator == (Employee left, Employee right)
        //{
        //    return left.Equals(right) ;
        //}
        //public static bool operator !=(Employee left, Employee right)
        //{
        //    return (left.Id != right.Id) || (left.Name != right.Name) || (left.Salary != right.Salary);
        //}



    }
}
