using Domain;

namespace Services.Linkers
{
    public interface ILinker<T>
    {
        T Link(T target, Entities entities);
    }
}
