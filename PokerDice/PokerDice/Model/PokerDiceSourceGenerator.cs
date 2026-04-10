using PokerDiceEngine.Model.Dice;

namespace PokerDiceEngine.Model
{
    public class PokerDiceSourceGenerator
    {
        private readonly Random _rng = new Random();

        public DiceContext Generate()
        {
            int[] dice = Enumerable.Range(0, 5)
           .Select(_ => _rng.Next(1, 7))
           .ToArray();

            return new DiceContext(dice);
        }

        public IEnumerable<int[]> GenerateCollection()
        {
            for (int a = 1; a <= 6; a++)
                for (int b = a; b <= 6; b++)
                    for (int c = b; c <= 6; c++)
                        for (int d = c; d <= 6; d++)
                            for (int e = d; e <= 6; e++)
                                yield return new[] { a, b, c, d, e };
        }

        public int GenerateDie()
        {
            return _rng.Next(1, 7);
        }

        public int GenerateRollIndex()
        {
            return _rng.Next(1, 4);
        }
    }
}
