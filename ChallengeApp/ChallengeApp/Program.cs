using ChallengeApp;
List<Employee> emplObj = new List<Employee>();  // ----- stwórz nową listę z pracownikami jako obiektami
emplObj.Add(new Employee("Mieczysław", "Karasiewicz", 24, 0));                                      
emplObj.Add(new Employee("Zenobia", "Miłoszyńska", 56, 0));
emplObj.Add(new Employee("Florian", "Majewski", 33, 0));
List<string> winner = new List<string>();       // ----- stwórz pustą listę zwycięzców i ustal maks. wynik jako -1
var maxScore = -1;
foreach (var employee in emplObj)       // ----- Dla każdego z pracowników:
{
    employee.AddRandomNotes(5);         // ----- 1) przydziel po pięć losowych ocen w skali 1-10
    var emplData = employee.emplData;   // ----- 2) scal dane osobowe
    var score = employee.Sum;           // ----- 3) sumuj punkty

    if (score > maxScore)
    {
        maxScore = score;
        winner.Clear();
        winner.Add(emplData);
    }
    else if (score == maxScore)
    {
        winner.Add(emplData);
    }
}
Console.WriteLine("Zwycięzca to: " + String.Join(", ", winner) + ". \nZdobyte punkty: " + maxScore + ". \nGratulujemy!");


// ----- PONIŻSZY FRAGMENT KODU SŁUŻY TYLKO POKAZANIU, jaką sumę punktów zdobył każdy pracownik i można go usunąć
Console.WriteLine("═════════");
List<string> allEmployees = new List<string>();
List<int> allScores = new List<int>();
foreach (var employee in emplObj)
{
    var emplData = employee.emplData;   // ----- scal dane osobowe
    var score = employee.Sum;           // ----- sumuj punkty
    allEmployees.Add(emplData);
    allScores.Add(score);
}
foreach (var res in allScores.Select((value, i) => new { i, value }))
{
    var value = res.value;
    var index = res.i;
    Console.WriteLine(value + " ◄── " + allEmployees[index]);
}