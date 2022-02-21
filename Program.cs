using System;

namespace netSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var salary = int.Parse(Console.ReadLine());

            var result = new Salary(salary);

            Console.WriteLine(result.NetSalary());

        }



    }

}
    

