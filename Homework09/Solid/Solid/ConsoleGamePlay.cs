
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
            Console.Write($"������� ����� �� {_gameSettings.MinValue} �� {_gameSettings.MaxValue}: ");
            int guess;
            while (!int.TryParse(Console.ReadLine(), out guess) || guess < _gameSettings.MinValue || guess > _gameSettings.MaxValue)
            {
                Console.WriteLine("������������ ����. ���������� �����.");
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
                    Console.WriteLine("�����������, �� �������!");
                }
                else
                {
                    Console.WriteLine(result.Guess < result.Target ? "���������� ����� ������" : "���������� ����� ������");
                }
            }

            if (!isCorrect)
            {
                Console.WriteLine($"�� �� �������. ���������� �����: {target}");
            }
        }
    }

}