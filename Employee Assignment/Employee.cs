using System;
namespace oopseg
{
    abstract class Employee
    {
        public int Empid
        {
            get;
            set;
        }
        public string? Empname
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
        public DateTime Doj
        {
            get;
            set;
        }
        
        public virtual void AcceptDetails()
        {
            Console.WriteLine("Enter the Employee ID");
            Empid=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            Empname=Console.ReadLine();
            Console.WriteLine("Enter the Date of Joining");
            Doj=Convert.ToDateTime(Console.ReadLine());
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee ID:-"+Empid);
            Console.WriteLine("Employee Name:-"+Empname);
            Console.WriteLine("Employee Salary:-"+Salary);
            Console.WriteLine("Employee Date of joining:-"+Doj);            
        }

        public abstract void CalculateSalary();
    }

    class Permenant:Employee
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

        public override void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("Enter the BasicPay");
            Basicpay=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the HRA");
            HRA=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the DA");
            DA=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the PF");
            PF=Convert.ToInt32(Console.ReadLine());
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
        }

        public override void CalculateSalary()
        {
            Salary=(Basicpay+HRA+DA-PF);
        }
    }

    class Trainee:Employee
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

        public override void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("Enter the Salary for Trainee");
            Tsalary=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Project name");
            Projectname=Console.ReadLine();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
        }

        public override void CalculateSalary()
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
    }
}