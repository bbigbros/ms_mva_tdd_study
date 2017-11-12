using MsAcademyTdd;
using Xunit;

namespace BowlingKata.Tests
{
    public class BowlingKataUnitTests
    {
        private Game _g;

        public BowlingKataUnitTests()
        {
            _g = new Game();
        }

        [Fact]
        public void OneSpareReturnsAppropriateValue()
        {
            // arrage
            _g.Roll(5);
            _g.Roll(5);  // spare
            _g.Roll(3);

            // act
            RollMany(17, 0);

            // assert
            Assert.Equal(16, _g.ScoreGame());
        }

        [Fact]
        public void OneStrikeReturnsAppropriateValue()
        {
            // arrage
            _g.Roll(10); // strike
            _g.Roll(3);
            _g.Roll(4);

            // act
            RollMany(16, 0);

            // assert
            Assert.Equal(24, _g.ScoreGame());
        }


        public void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                _g.Roll(pins);
            }
        }
    }
}
