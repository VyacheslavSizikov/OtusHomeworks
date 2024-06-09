

namespace Solid
{
    // Принцип подстановки Барбары Лисков (Liskov Substitution Principle)
    public interface IGameSettings
    {
        int MinValue { get; }
        int MaxValue { get; }
        int MaxAttempts { get; }
    }
}