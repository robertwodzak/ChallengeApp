namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectsThreeScores_ShouldReturnCorrectResult() // TEST #1 - tylko dodawane punkty
        {
            // arrange
            List<User> userObj = new List<User>();  // ----- stwórz now¹ listê z userami jako obiektami
            userObj.Add(new User("Jadwiga", "W¹sik", 24, 0));
            userObj[0].AddScore(5);
            userObj[0].AddScore(6);
            userObj[0].AddScore(2);

            // act
            var result = userObj[0].Result;

            // assert
            Assert.AreEqual(13, result);
        }
        [Test]
        public void WhenUserHasPenalty_ShouldSubtractPenaltyFromScore() // TEST #2 - dodawane punkty i odejmowane punkty karne
        {
            // arrange
            List<User> userObj = new List<User>();  // ----- stwórz now¹ listê z userami jako obiektami
            userObj.Add(new User("Iga", "Michalewska", 19, 0));
            userObj[0].AddScore(2);
            userObj[0].AddScore(4);
            userObj[0].AddScore(7);
            userObj[0].SubtractPenalty(3);

            // act
            var result = userObj[0].Result;

            // assert
            Assert.That(result, Is.EqualTo(10));

        }
    }
}