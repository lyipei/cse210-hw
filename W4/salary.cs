using system

public abstract class Employee
{
    public string Name {set; private set;};

    public Employee(string name)
    {Name = name};

    public abstract double CalculateSalary();
}
public class FullTimeEmplyee : Employee
{
    private double monthlySalary:
    public FullTimeEmplyee(string name, double monthlySalary)
        : base(name)
    {
        this.monthlySalary = monthlySalary;
    }
    public override double CalculateSalary()
    {
        return monthlySalary;
    }
}
public class PartTimeEmployee : Employee
{
    private double hourlyRate;
    private int hoursWorked;
    public PartTimeEmployee(string name, double hourlyRate, int hoursWorked)
            : base(name)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }
    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }
}
