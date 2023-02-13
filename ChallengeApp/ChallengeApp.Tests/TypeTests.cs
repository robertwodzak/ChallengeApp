namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CheckIfTwoIntegersAreEqual() // Testowanie typów wartościowych "int"
        {
            int number1 = 112 % 3; // arrange
            int number2 = 7 % 3;
            Assert.AreEqual(number1, number2); // assert
        }
        [Test]
        public void CheckIfTwoFieldsAreEqual() // Testowanie typów wartościowych "float"
        {            
            float diamondHalfXDiamXDiam = 0.5F * 8 * 6; // arrange
            float diamondAxH = 5 * 4.8F;
            Assert.AreEqual(diamondHalfXDiamXDiam, diamondAxH); // assert
        }
        [Test]
        public void CheckIfTwoTextsAreNotEqual() // Testowanie typów wartościowych "string"
        {
            string text1 = "hello world"; // arrange
            string text2 = "Hello World";
            Assert.AreNotEqual(text1, text2); // assert
        }
        [Test]
        public void GetUserNamesShouldReturnEqualNames() // Testowanie typów wartościowych "string" w obiekcie
        {
            var user1 = GetUser("Ola", "Z.", 37, 0); // arrange
            var user2 = GetUser("Ola", "J.", 19, 0);
            Assert.AreEqual(user1.Name, user2.Name); // assert ←――――― UWAGA! korzysta z pola Name w klasie User.cs 
        }
        [Test]
        public void GetUserShouldReturnDifferentObjects() // testowanie typów referencyjnych
        {
            var user1 = GetUser("Ola", "Z.", 37, 0); // arrange
            var user2 = GetUser("Ola", "J.", 19, 0);
            Assert.AreNotEqual(user1, user2); // assert
        }
        private User GetUser(string name, string surname, int age, int points)
        {
            return new User(name, surname, age, points);
        }
    }
}