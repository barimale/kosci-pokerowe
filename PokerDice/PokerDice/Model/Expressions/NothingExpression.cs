using PokerDiceEngine.Abstraction;
using PokerDiceEngine.Model.Dice;

namespace PokerDiceEngine.Model.Expressions
{
    public class NothingExpression : IExpression
    {
        public DiceResult? Interpret(int[] dice)
        {
            return new DiceResult()
            {
                Type = DiceType.HighDice,
                Result = 0
            };
        }
    }

}
