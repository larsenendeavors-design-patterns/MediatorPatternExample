using System;

namespace MediatorPatternExample.Objects
{
    public class AbilityScoreTextBoxComponent : Component
    {
        private int Score { get; }
        
        public AbilityScoreTextBoxComponent(IMediator mediator, int score) : base(mediator)
        {
            Score = score;
        }

        public override bool Validate()
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