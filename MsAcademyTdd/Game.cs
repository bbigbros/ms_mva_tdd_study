﻿namespace MsAcademyTdd
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
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex)) // spare
                {
                    score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
                
            }
            return score;
        }

        public bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        public bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        public int StrikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
    }
}
