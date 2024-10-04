using ChallengeApp;

var employee = new Employee("Krysia", "Kowalska");


employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(9); 

var statistics = employee.GetStatistics();

Console.WriteLine($"Avarage: {statistics.Avarage:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(out statistics);
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
    //statistics = new Statistics();
}




