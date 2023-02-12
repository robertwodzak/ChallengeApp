namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectsThreeScores_ShouldReturnCorrectResult()
        {
            // arrange
            List<User> userObj = new List<User>();  // ----- stwórz now¹ listê z userami jako obiektami
            userObj.Add(new User("Mieczys³aw", "Karasiewicz", 24, 0));
            userObj[0].AddScore(5);
            userObj[0].AddScore(6);
            userObj[0].AddScore(2);
            
            // act
            var result = userObj[0].Result;

            // assert
            Assert.AreEqual(13, result); 
        
        }
        [Test]
        public void WhenUserHasPenalty_ShouldSubtractPenaltyFromScore()
        {
            // arrange
            List<User> userObj = new List<User>();  // ----- stwórz now¹ listê z userami jako obiektami
            userObj.Add(new User("Mieczys³aw", "Karasiewicz", 24, 0));
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
