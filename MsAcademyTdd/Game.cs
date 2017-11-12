namespace MsAcademyTdd
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int ScoreGame()
        {
            int score = 0;
            int rollNum = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                // spare
                if (rolls[rollNum] + rolls[rollNum + 1] == 10)
                {
                    score += 10 + rolls[rollNum + 2];
                }
                else
                {
                    score += rolls[rollNum] + rolls[rollNum + 1];
                }
                rollNum += 2;
            }
            return score;
        }
    }
}
