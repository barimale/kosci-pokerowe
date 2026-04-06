namespace PokerDiceEngine.Model.Dice
{
    public class GameState
    {
        public GameState(int[] dices, int rerollsLeft)
        {
            Dice = dices;
            RerollsLeft = rerollsLeft;
        }

        public int[] Dice { get; set; }
        public int RerollsLeft { get; set; }
    }
}
