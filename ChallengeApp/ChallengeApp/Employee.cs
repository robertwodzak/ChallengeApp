namespace ChallengeApp
{
    public class Employee
    {
            private List<float> grades = new List<float>();
      
        public Employee(string name, string surname) // tu jest konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }
       
        
        public string Name { get; private set; } // tu są pola
        public string Surname { get; private set; }
      
        public void AddGrade (float grade)  // tu są metody, ta metoda nic nie zwraca (void) 
        {
            this.grades.Add(grade);
        }       
        public Statistics GetStatistics() // metoda, która zwraca wypełniony Model danych ze statystykami
        {
            var statistics = new Statistics(); // przygotowujemy obiekt
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            if (this.grades.Count == 0)
            {
                statistics.Average = 0;
                statistics.Min = 0;
                statistics.Max = 0;
            }
            else
            {
                statistics.Average /= this.grades.Count;
            }

            return statistics; 
        }           
    }
}