using ChallengeApp;

Employee employee1 = new Employee("Dominika", "Kowalska", 31, 0);
Employee employee2 = new Employee("Monika", "Młynarska", 24, 0);
Employee employee3 = new Employee("Zuzia", "Słowik", 42, 0);


employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(5);
employee1.AddScore(4);

employee2.AddScore(2);
employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(3);

employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        EmployeeWithMaxResult = employee;
    }
}

Console.WriteLine(EmployeeWithMaxResult.Name);
Console.WriteLine(EmployeeWithMaxResult.LastName);
Console.WriteLine(EmployeeWithMaxResult.Age);
Console.WriteLine("Punkty:" + EmployeeWithMaxResult.Result);

