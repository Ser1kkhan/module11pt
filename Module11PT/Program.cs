using System;

namespace EmployeeManagement
{
    // Define job positions
    public enum Vacancies
    {
        Manager,
        Developer,
        Designer,
        Tester
    }

    // Define the structure for Employee
    public struct Employee
    {
        public string name;
        public Vacancies vacancy;
        public int[] hiringDate; // Format: [day, month, year]
        public int salary;

        // Constructor to initialize an Employee
        public Employee(string name, Vacancies vacancy, int[] hiringDate, int salary)
        {
            this.name = name;
            this.vacancy = vacancy;
            this.hiringDate = hiringDate;
            this.salary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an employee
            Employee employee = new Employee(
                "Frederich Hindenburg",
                Vacancies.Designer,
                new int[] { 12, 4, 2020 },
                40000
            );

            // Display employee information
            Console.WriteLine("Employee Information:");
            Console.WriteLine("Name: " + employee.name);
            Console.WriteLine("Job Position: " + employee.vacancy);
            Console.WriteLine("Hiring Date: " + employee.hiringDate[0] + "/" + employee.hiringDate[1] + "/" + employee.hiringDate[2]);
            Console.WriteLine("Salary: " + employee.salary);
            Console.ReadKey();
        }
    }
}
