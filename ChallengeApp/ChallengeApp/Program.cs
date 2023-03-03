using ChallengeApp;

var employee = new Employee("Anna", "Miłoszyńska");
employee.AddGrade(7);
employee.AddGrade(4);
employee.AddGrade(3);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");