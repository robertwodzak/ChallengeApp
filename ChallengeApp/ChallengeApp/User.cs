namespace ChallengeApp
{
    public class User
    {
        private List<int> points = new List<int>();
        public User(string name, string surname, int age, int points) // tu jest konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; } // tu są pola
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.points.Sum();
            }
        }
        public string userData
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
        public void SubtractPenalty(int number)  
        {
            this.points.Add(-1*number);
        }
    }   
}