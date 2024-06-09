namespace Prototype
{
    // Интерфейс IMyCloneable для реализации шаблона "Прототип"
    public interface IMyCloneable<T>
    {
        T Clone();
    }
}
