using System;

namespace MediatorPatternExample.Objects
{
    public class AbilityScoreTextBox : Component
    {
        private int Score { get; }
        
        public AbilityScoreTextBox(IMediator mediator, int score) : base(mediator)
        {
            Score = score;
        }

        public bool ValidateScore()
        {
            if (Score > 20)
            {
                Console.WriteLine("Score is above 20 at: " + Score);
                return false;
            }

            if (Score <= 0)
            {
                Console.WriteLine("Score is below at or below 0 at: " + Score);
                return false;
            }

            return true;
        }
    }
}