using ChallengeApp;
Employee employee1 = new Employee("Mieczysław", "Karasiewicz", 24, 0);
Employee employee2 = new Employee("Zenobia", "Miłoszyńska", 56, 0);
Employee employee3 = new Employee("Florian", "Majewski", 33, 0);
employee1.AddRandomNotes(5); // ----- przydziel po pięć losowych ocen 1-10 pracownikom
employee2.AddRandomNotes(5);
employee3.AddRandomNotes(5);
var result1 = employee1.Sum; // ----- pokaż sumę punktów uzyskanych przez pracowników
var result2 = employee2.Sum;
var result3 = employee3.Sum;
var emplData1 = employee1.emplData; // ----- scal dane osobowe pracowników
var emplData2 = employee2.emplData;
var emplData3 = employee3.emplData;
// ----- stwórz listę z danymi osobowymi pracowników i listę z ich wynikami
List<string> employees = new List<string> {emplData1, emplData2, emplData3};
List<int> wyniki = new List<int> {result1, result2, result3};
// ----- Ile wynosi maks. ilość zdobytych punktów? Kto zdobył? (Co jeśli kilka osób? → lista)
int maxPoints = wyniki.Max();
List<string> winner = new List<string>();
foreach (var res in wyniki.Select((value, i) => new { i, value }))
{
    var value = res.value;
    var index = res.i;
    Console.WriteLine(value + " ◄── " + employees[index]);
    if (value == maxPoints)
    {
        winner.Add(employees[index]);
    }
}
Console.WriteLine("═════════\nZwycięzca to: " + String.Join(", ", winner) + ". \nZdobyte punkty: " + maxPoints+". \nGratulujemy!");