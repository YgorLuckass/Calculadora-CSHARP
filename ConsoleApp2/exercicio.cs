using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

internal class exercicio
{
    public int Id;
    public string Name;
    public double Salary;

    public exercicio(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void IncreaseSalary(double percentage)
    {
        Salary += Salary * percentage / 100;
    }

    public override string ToString()
    {
        return Id + ", " + Name + ", " + Salary.ToString("F2",CultureInfo.InvariantCulture);
    }
}

