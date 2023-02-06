namespace ChallengeApp
{
    public class Employee
    {
        private List<int> points = new List<int>();
        public Employee(string name, string surname, int age, int points) // tu jest konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; } // tu są pola
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Sum
        {
            get
            {
                return this.points.Sum();
            }
        }
        public string emplData
        {
            get
            {
                return string.Join(" ", this.Name, this.Surname) + " (" + this.Age + ")";
            }
        }
        public void AddScore(int number)  // tu są metody
        {
            this.points.Add(number);
        }
        public void AddRandomNotes(int howManyNotes)
        {
            Random rand = new Random();
            for (int i = 0; i < howManyNotes; i++)
            {
                int points = rand.Next(1, 10);
                this.AddScore(points);
            }
        }

    }
}