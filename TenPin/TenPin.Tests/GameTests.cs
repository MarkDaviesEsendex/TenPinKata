using NUnit.Framework;

namespace TenPin.Tests
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void TestScoreIsConsistentWithPinsKnockedDown()
        {
            var game = new Game();
            game.Roll(7);
            Assert.AreEqual(7, game.Score());
        }

        [Test]
        public void TestFollowingBallAddsScoreToPreviousFrameWhenPreviousFrameIsSpare()
        {
            var game = new Game();

            game.Roll(3);
            game.Roll(7);

            game.Roll(1);

            Assert.AreEqual(12, game.Score());
        }
    }
}
