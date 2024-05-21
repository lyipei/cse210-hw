class program
{
    static void Main(string[] arge)
    {
        Employee fullTimeEmployee = new FullTimeEmployee("John Smith", 5000);
        Employee partTimeEmployee = new PartTimeEmployee("Anna Whits", 25, 40);

        double fullTimeSalary = fullTimeEmployee.CalculateSalary();
        double partTimeSalary = partTimeEmployee.CalculateSalary();

        Console.WriteLine($"Full-Time Employee Salary: ${fullTimeSalary}");
        Console.WriteLine($"Part-Time Employee Salary: ${partTimeSalary}");

    }
}