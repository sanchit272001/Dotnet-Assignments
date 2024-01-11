namespace oopseg
{
    class EmployeeClient
    {
        public static void main()
        {
            // Employee e1=new Permenant();
            IEmployee e1=new Permenantt();
            e1.AcceptDetails();            
            e1.CalculateSalary();
            e1.DisplayDetails();
            // e1=new Traineee();
            // e1.AcceptDetails();
            // e1.CalculateSalary();
            // e1.DisplayDetails();
        }
    }
}