
namespace Solid
{
    public class DefaultGameSettings : IGameSettings
    {
        public int MinValue => 1;
        public int MaxValue => 100;
        public int MaxAttempts => 3;
    }
}
