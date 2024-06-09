
namespace Solid
{
    public class GuessResult : IGuessResult
    {
        public bool IsCorrect { get; }
        public int Guess { get; }
        public int Target { get; }

        public GuessResult(int guess, int target)
        {
            Guess = guess;
            Target = target;
            IsCorrect = guess == target;
        }
    }

}