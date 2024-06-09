namespace Solid
{
    public interface INumberGenerator
    {
        /// <summary>
        /// Генерирует случайное число в заданном диапазоне.
        /// </summary>
        /// <returns>Сгенерированное число.</returns>
        int GenerateNumber();

        /// <summary>
        /// Получает минимальное значение диапазона.
        /// </summary>
        int MinValue { get; }

        /// <summary>
        /// Получает максимальное значение диапазона.
        /// </summary>
        int MaxValue { get; }
    }
}
