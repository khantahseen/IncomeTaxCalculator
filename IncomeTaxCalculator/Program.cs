using System;

namespace IncomeTaxCalculator
{
    class TaxCalculator
    {
        public double Salary{ get; set; }
        public int Age { get; set; }
        public double IncomeTax;
        
        public TaxCalculator(double salary, int age)
        {
            Salary = salary;
            Age = age;

        }

        private double _slabA= 0.05;
        private double _slabB =0.15;
        private double _slabC =0.3;

        public double CalculateTax()
        {
            if(Age>80)
            {
                if (Salary <= 500000)
                {
                    IncomeTax = 0;
                    return IncomeTax;
                }
                else if (Salary > 1000000)
                {
                    IncomeTax = 100000 + (Salary - 100000) * _slabC;
                    return IncomeTax;
                }
                else if (Salary > 500001 && Salary < 1000000)
                {
                    IncomeTax = 0.2 * Salary;
                    return IncomeTax;
                }
                else
                    return 0;
                
            }

            else if(Age>60 && Age<=80)
            {
                if(Salary<=300000)
                {
                    IncomeTax = 0;
                    return IncomeTax;
                }
                else if(Salary > 300000 && Salary <= 500000)
                {
                    IncomeTax = _slabA * Salary;
                    return IncomeTax;
                }
                else if(Salary > 500000 && Salary <=1000000)
                {
                    IncomeTax = 10000 + (Salary - 500000) * _slabB;
                    return IncomeTax;
                }
                else if(Salary>=1000000)
                {
                    IncomeTax = 110000 + (Salary - 1000000) * _slabC;
                    return IncomeTax;

                }
                else
                    return 0;
            }

            else if(Age<61)
            {
                if (Salary <= 250000)
                {
                    IncomeTax = 0;
                    return IncomeTax;
                }
                else if (Salary > 250000 && Salary <= 500000)
                {
                    IncomeTax = _slabA * Salary;
                    return IncomeTax;
                }
                else if (Salary > 500000 && Salary <= 1000000)
                {
                    IncomeTax = 12500 + (Salary - 500000) * _slabB;
                    return IncomeTax;
                }
                else if (Salary >= 1000000)
                {
                    IncomeTax = 112500 + (Salary - 1000000) * _slabC;
                    return IncomeTax;

                }
                else
                    return 0;
            }
            else
                return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Salary:");
            double salary = Convert.ToInt32(Console.ReadLine());

            var obj = new TaxCalculator(salary, age);
            double TaxValue = obj.CalculateTax();

            Console.WriteLine($"The Annual Income Tax Value to be paid by the Employee of Age:{age} and Salary:{salary} is:" +TaxValue);
        }
    }
}
