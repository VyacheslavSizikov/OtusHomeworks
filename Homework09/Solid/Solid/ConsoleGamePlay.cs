
namespace Solid
{
    public class ConsoleGamePlay : IUserInput, IGamePlay
    {
        private readonly INumberGenerator _numberGenerator;
        private readonly IGameSettings _gameSettings;

        public ConsoleGamePlay(INumberGenerator numberGenerator, IGameSettings gameSettings)
        {
            _numberGenerator = numberGenerator;
            _gameSettings = gameSettings;
        }

        public int GetGuess()
        {
            Console.Write($"Введите число от {_gameSettings.MinValue} до {_gameSettings.MaxValue}: ");
            int guess;
            while (!int.TryParse(Console.ReadLine(), out guess) || guess < _gameSettings.MinValue || guess > _gameSettings.MaxValue)
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
            return guess;
        }

        public void Play()
        {
            int target = _numberGenerator.GenerateNumber();
            int attempts = 0;
            bool isCorrect = false;

            while (attempts < _gameSettings.MaxAttempts && !isCorrect)
            {
                int guess = GetGuess();
                IGuessResult result = new GuessResult(guess, target);
                attempts++;

                if (result.IsCorrect)
                {
                    isCorrect = true;
                    Console.WriteLine("Поздравляем, вы угадали!");
                }
                else
                {
                    Console.WriteLine(result.Guess < result.Target ? "Загаданное число больше" : "Загаданное число меньше");
                }
            }

            if (!isCorrect)
            {
                Console.WriteLine($"Вы не угадали. Загаданное число: {target}");
            }
        }
    }

}