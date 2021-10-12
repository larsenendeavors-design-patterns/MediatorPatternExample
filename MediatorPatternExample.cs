using System;
using MediatorPatternExample.Objects;

namespace MediatorPatternExample
{
    internal static class MediatorPatternExample
    {
        
        /*
         * The majority of this code is mocked or directly taken from https://refactoring.guru/design-patterns/mediator
         * in an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/12
         */
        
        private static void Main()
        {
            
            // This is the gist of the mediator pattern, here we have two components that are sending their events to
            // the mediator, who is then properly calling methods with access to all other components.  Although this
            // mediator doesn't have a list of all its components, that might be a valid option for some.
            
            var mediator = new Mediator();
            var abilityScoreTextBox1 = new AbilityScoreTextBoxComponent(mediator, 19);
            var abilityScoreTextBox2 = new AbilityScoreTextBoxComponent(mediator, 21);
            
            abilityScoreTextBox1.Click();
            abilityScoreTextBox2.KeyPress();

            var diceFormulaTextBox1 = new DiceFormulaTextBoxComponent(mediator, "1d12 + 20");
            var diceFormulaTextBox2 = new DiceFormulaTextBoxComponent(mediator, "1a12 + 20");
            
            diceFormulaTextBox1.Click();
            diceFormulaTextBox2.KeyPress();
        }
    }
}