namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectsFourScores_ShouldReturnCorrectAverageResult() // TEST #1 - oblicz œredni¹
        {
            // arrange
            var employee = new Employee("Michalina", "Kwietniewicz");  // ----- stwórz nowego mployee
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();
            var average = statistics.Average;

            // assert
            Assert.AreEqual(4.25, average);
        }
        [Test]
        public void WhenEmployeeCollectsThreeScores_ShouldReturnCorrectMaxResult() // TEST #2 - wska¿ wartoœæ maksymaln¹
        {
            // arrange
            var employee = new Employee("Bogdan", "Wilczyñski");  // ----- stwórz nowego Employee
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(2);

            // act
            var statistics = employee.GetStatistics();
            var max = statistics.Max;

            // assert
            Assert.AreEqual(6, max);
        }
        [Test]
        public void WhenEmployeeCollectsThreeScores_ShouldReturnCorrectMinResult() // TEST #3 - wska¿ wartoœæ minimaln¹
        {
            // arrange
            var employee = new Employee("Julia", "Milewska");  // ----- stwórz nowego Employee
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(2);

            // act
            var statistics = employee.GetStatistics();
            var min = statistics.Min;

            // assert
            Assert.AreEqual(2, min);
        }
        [Test]
        public void WhenEmployeeCollectsNoGrade_ShouldReturnAZeroInsteadOfAverageMinAndMax() // TEST #4 - wyœwietl 0 przy przeliczaniu œredniej, gdy nie zdobyto ¿adnych ocen
        {
            // arrange
            var employee = new Employee("Zuzanna", "Nieoceniona");  // ----- stwórz nowego Employee
            
            // act
            var statistics = employee.GetStatistics();
            var average = statistics.Average;
            var min = statistics.Min;
            var max = statistics.Max;

            // assert
            Assert.AreEqual(0, average);
            Assert.AreEqual(0, min);
            Assert.AreEqual(0, max);
        }
    }
}