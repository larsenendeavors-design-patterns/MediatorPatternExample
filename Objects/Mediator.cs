using System;

namespace MediatorPatternExample.Objects
{
    public class Mediator : IMediator
    {
        public void Notify(Component sender, string eventString)
        {
            if (sender is AbilityScoreTextBoxComponent abilityScoreTextBox)
            {
                if (eventString == "click")
                {
                    Console.WriteLine("AbilityScoreTextBox Clicked");
                    abilityScoreTextBox.Validate();
                }

                if (eventString == "keyPress")
                {
                    Console.WriteLine("AbilityScoreTextBox KeyPress");
                    abilityScoreTextBox.Validate();
                }
            }
            
            if (sender is DiceFormulaTextBoxComponent diceFormulaTextBoxComponent)
            {
                if (eventString == "click")
                {
                    Console.WriteLine("diceFormulaTextBoxComponent Clicked");
                    diceFormulaTextBoxComponent.Validate();
                }

                if (eventString == "keyPress")
                {
                    Console.WriteLine("diceFormulaTextBoxComponent KeyPress");
                    diceFormulaTextBoxComponent.Validate();
                }
            }
        }
        
    }
}