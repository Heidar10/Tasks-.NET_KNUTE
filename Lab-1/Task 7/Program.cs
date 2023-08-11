using System;


namespace Task_7
{
    class Employee
    {
        static void Main(string[] args)
        { 

                private readonly string name;
                private decimal salary;
                private string position;
                public Employee(string name, decimal salary,string position)
                {
                    this.name = name;
                    this.salary = salary;
                    this.position = position;

                }
                public string Position
                {
                    get
                    {
                        return position;
                    }
                }
                public string Name
                {
                    get
                    {
                        return name;
                    }
                }
                public virtual decimal Salary
                {
                    get
                    {
                        return salary;
                    }
                    set
                    {
                        salary = value;
                    }
                }
                public decimal GetMonthlyPayment()
                {
                    return salary / 12;
                }
                public override string ToString()
                {
                    return "Name and Surname: " + name + ", Salary: $" + salary.ToString()+", Position"+position;
                }
          }
     
    }
}    

   
