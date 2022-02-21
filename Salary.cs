using System;
using System.Collections.Generic;
using System.Text;

namespace netSalary
{
    class Salary
    {


        private readonly decimal salary;
        public decimal GetSalary() => salary;
        public Salary(decimal salary)
        {
            this.salary = salary;
        }

        public const int maxAmounts = 3000;
        public const int noTaxation = 1000;

        // calculation all net salary
        public decimal NetSalary() 
        {
            decimal result = 0M;
            if(GetSalary() > 1000)
            {
                result = GetSalary() - Taxes();
            }
            return result;
        }

        // calculation and return of all due contributions
        public  decimal Taxes()
        {

            var incomeResult = IncomeTax();
            var socialResult = SocialContributions();

            var allTaxes = incomeResult + socialResult;

            return allTaxes;
        }

        // calculation and return of due social contributions
        public  decimal SocialContributions()
        {
            var result = GetSalary();
            if (result > maxAmounts)
            {
                result = maxAmounts;
            }

            result -= noTaxation;

            decimal socialTax = result * 0.15M;
            return socialTax;
        }

        // calculation and refund of tax due
        public decimal IncomeTax()
        {
            var result = GetSalary();

            result -= noTaxation;

            decimal incomeTax = result * 0.1M;

            return incomeTax;
        }

        // convert GetSalary in string
        public override string ToString()
        {
            
            return $"{this.GetSalary()}";
        }
    }

    
}






