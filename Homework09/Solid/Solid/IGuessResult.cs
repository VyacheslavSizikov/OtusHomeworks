namespace Solid
{
    // ������� ����������/���������� (Open/Closed Principle)
    public interface IGuessResult
    {
        bool IsCorrect { get; }
        int Guess { get; }
        int Target { get; }
    }
}