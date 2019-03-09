namespace GameData.Mappers
{
    public interface IMapper<X, T>
    {
        X Convert(T domainSource);
        T Convert(X xmlSource);
    }
}
