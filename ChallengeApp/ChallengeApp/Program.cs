using ChallengeApp;
List<User> userObj = new List<User>();  // ----- stwórz nową listę z userami jako obiektami
userObj.Add(new User("Mieczysław", "Karasiewicz", 24, 0));                                      
userObj.Add(new User("Zenobia", "Miłoszyńska", 56, 0));
userObj.Add(new User("Florian", "Majewski", 33, 0));
List<string> winner = new List<string>();       // ----- stwórz pustą listę zwycięzców i ustal maks. wynik jako -1
var maxScore = -1;
// ----- Zdobyte punkty przez userów
userObj[0].AddScore(7);
userObj[0].AddScore(9);
userObj[0].AddScore(10);
userObj[0].AddScore(8);
userObj[0].AddScore(10);

userObj[1].AddScore(5);
userObj[1].AddScore(3);
userObj[1].AddScore(1);
userObj[1].AddScore(2);
userObj[1].AddScore(1);

userObj[2].AddScore(5);
userObj[2].AddScore(4);
userObj[2].AddScore(3);
userObj[2].AddScore(4);
userObj[2].AddScore(4);
// ----- Otrzymane punkty ujemne
userObj[0].SubtractPenalty(38);
userObj[1].SubtractPenalty(1);
userObj[2].SubtractPenalty(5);
foreach (var user in userObj)       // ----- Dla każdego z userów:
{
    var userData = user.userData;   // ----- 1) scal dane osobowe
    var score = user.Result;           // ----- 2) Sumuj punkty

    if (score > maxScore)
    {
        maxScore = score;
        winner.Clear();
        winner.Add(userData);
    }
    else if (score == maxScore)
    {
        winner.Add(userData);
    }
}
Console.WriteLine("Zwycięzca to: " + String.Join(", ", winner) + ". \nZdobyte punkty: " + maxScore + ". \nGratulujemy!");