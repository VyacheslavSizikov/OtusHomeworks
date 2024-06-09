

namespace Solid
{
    // ������� ����������� ������� ������ (Liskov Substitution Principle)
    public interface IGameSettings
    {
        int MinValue { get; }
        int MaxValue { get; }
        int MaxAttempts { get; }
    }
}