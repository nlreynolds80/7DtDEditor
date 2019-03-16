using Domain;

namespace Services.Linkers
{
    public interface ILinker<T>
    {
        T Link(Entities entities);
    }
}
