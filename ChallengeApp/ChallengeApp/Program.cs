int number = 7586267;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
Console.WriteLine("Wyniki dla liczby: "+number);

// ----- stwórz listę counter zawierającą 10 elementów z ilością powtórzeń kolejnych cyfr
List<int> counter = new List<int>(new int[10]);

// ----- sprawdź każdy element tablicy letters (char zamień na liczbę)
// ----- dodaj +1 do odpowiedniego indeksu na liście counter
for (int dig = 0; dig < letters.Length; dig++)
{
    var whichDig = int.Parse(letters[dig].ToString());
    counter[whichDig]++;
}

// ----- przedstaw rozwiązanie zadania, pokazując po kolei elementy listy counter
var j = 0;
foreach (var elem in counter)
{
    Console.WriteLine(j + " => " + elem);
    j++;
}