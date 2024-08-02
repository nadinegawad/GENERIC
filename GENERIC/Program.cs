using System.Drawing;

namespace GENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Swap Ex
            //int A = 10, B = 20;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Helper<int>.Swap(ref A, ref B);
            //Console.WriteLine("After Swaping=================");
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //double X = 10.5, Y = 20.9;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            //Helper<double>.Swap(ref X, ref Y);
            //Console.WriteLine("After Swaping=================");
            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            //Point P01 = new Point(1, 2);
            //Point P02 = new Point(3, 4);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);
            //Helper<Point>.Swap(ref P01, ref P02);
            //Console.WriteLine(P01);
            //Console.WriteLine(P02);

            #endregion

            #region search ex

            //int[] array = { 1, 2, 3, 15, 11, 7, 9, 6, 10, 99 };
            //int index = Helper<int>.SearchArray(array, 15);
            //Console.WriteLine(index);

            //Employee E01 = new Employee(1, "Amr", 7000);
            //Employee E02 = new Employee(2, "Ahmed", 9000);
            //Employee E03 = new Employee(2, "Ahmed", 9000);
            //if (E02.Equals(E03))
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //Employee[] employees = new Employee[2]
            //{
            //    E01, E02
            //};
            //int index =Helper<Employee>.SearchArray(employees, E03);

            //Console.WriteLine(index); 
            #endregion

            #region Hash code ex

            //Employee E01 = new Employee(1, "Amr", 7000);
            //Employee E02 = new Employee(1, "Amr", 7000);
            //if (E01.Equals(E02))
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}
            //if (E01 == E02)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}
            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode()); 
            #endregion

            #region bubble sort
            //int[] numbers = { 15, 19, 1, 3, 12, 5, 11, 25, 2 };
            //foreach(int i in numbers)
            //{
            //    Console.Write ($" {i}");
            //}
            //Helper<int>.BubbleSort(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.Write($" {i}");
            //}

            //Employee[] employees = new Employee[]
            //{
            //    new Employee() {Id=1,Name="amr",Salary=10000},
            //    new Employee() {Id=2,Name="ahmed",Salary=5000},
            //    new Employee() {Id=3,Name="aya",Salary=3000},
            //    new Employee() {Id=4,Name="belal",Salary=7000},

            //};

            //Helper<Employee>.BubbleSort(employees);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //} 


            //Point[] points = new Point[]
            //{
            //    new Point(7,2),
            //    new Point(2,7),
            //    new Point(5,3),
            //    new Point(8,1),
            //    new Point(1,3),
            //    new Point(9,5),
            //};
            //Helper<Point>.BubbleSort(points);

            //foreach (Point point in points)
            //{
            //    Console.WriteLine(point);
            //}

            #endregion
        }
    }
}