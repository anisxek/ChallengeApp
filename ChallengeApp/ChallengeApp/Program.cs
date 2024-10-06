using ChallengeApp;

var employee = new Employee("Krysia", "Kowalska");


employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(6);
employee.AddGrade(9); 

var statistics = employee.GetStatistics();

Console.WriteLine($"Avarage: {statistics.Avarage:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");





