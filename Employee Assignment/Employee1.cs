using System;
namespace oopseg
{
    class Permenantt : IEmployee
    {
        public int Basicpay
        {
            get;
            set;
        }
        public int HRA
        {
            get;
            set;
        }
        public int DA
        {
            get;
            set;
        }
        public int PF
        {
            get;
            set;
        }

        public int Salary
        {
            get;
            set;
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter the BasicPay");
            Basicpay=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the HRA");
            HRA=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the DA");
            DA=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the PF");
            PF=Convert.ToInt32(Console.ReadLine());
        }

        public void CalculateSalary()
        {
            Salary=Basicpay+HRA+DA-PF;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Salary:- "+Salary);
        }
    }

    class Traineee : IEmployee
    {

        public int Tsalary
        {
            get;
            set;
        }
        public double Bonus
        {
            get;
            set;
        }
        public string? Projectname
        {
            get;
            set;
        }

        public double Salary
        {
            get;
            set;
        }


        public void AcceptDetails()
        {
            Console.WriteLine("Enter the Salary for Trainee");
            Tsalary=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Project name");
            Projectname=Console.ReadLine();
        }

        public int add(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void CalculateSalary()
        {
            if(Projectname=="Banking")
            {
                Bonus=0.05*Tsalary;
            }
            else
            {
                Bonus=0.1*Tsalary;
            }
            Salary=Tsalary+Bonus;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Salary:- "+Salary);
        }

        public int div(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int mul(int x, int y)
        {
            throw new NotImplementedException();
        }

        public int sub(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}