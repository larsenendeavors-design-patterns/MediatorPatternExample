using System;
using System.Text.RegularExpressions;

namespace MediatorPatternExample.Objects
{
    public class DiceFormulaTextBoxComponent : Component
    {
        private string DiceFormula { get; }

        public DiceFormulaTextBoxComponent(IMediator mediator, string diceFormula) : base(mediator)
        {
            DiceFormula = diceFormula;
        }

        public override bool Validate()
        {
            var regex = new Regex("\\d\\s?[d]\\s?\\d\\d?\\s?[+|-]\\s?\\d\\d?\\d{1,3}");
            if (regex.IsMatch(DiceFormula))
            {
                Console.WriteLine(DiceFormula + " is a valid dice formula");
                return true;
            }
            Console.WriteLine(DiceFormula + " is not a valid dice formula");
            return false;
        }
    }
}