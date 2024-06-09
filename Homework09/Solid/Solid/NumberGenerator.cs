
namespace Solid
{
    public class NumberGenerator : INumberGenerator
    {
        private readonly int _minValue;
        private readonly int _maxValue;
        private readonly Random _random;

        public NumberGenerator(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            _random = new Random();
        }

        public int MinValue => _minValue;

        public int MaxValue => _maxValue;

        public int GenerateNumber()
        {
            return _random.Next(_minValue, _maxValue + 1);
        }
    }
}
