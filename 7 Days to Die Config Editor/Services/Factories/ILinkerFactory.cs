using Services.Linkers;

namespace Services.Factories
{
    public interface ILinkerFactory
    {
        ILinker<T> GetLinker<T>(T target);
    }
}
