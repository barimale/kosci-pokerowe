using PokerDice.AI.DataModel;

namespace PokerDice.AI.Training
{
    public class DiceStateComparer : IEqualityComparer<DiceState>
    {
        public bool Equals(DiceState x, DiceState y)
            => x.Die1.Equals(y.Die1) &&
            x.Die2.Equals(y.Die2) &&
            x.Die3.Equals(y.Die3) &&
            x.Die4.Equals(y.Die4) &&
            x.Die5.Equals(y.Die5);

        public override int GetHashCode()
{
    return HashCode.Combine(Die1, Die2, Die3, Die4, Die5);
}
    }
