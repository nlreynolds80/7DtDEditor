namespace GameData.Mappers
{
    public interface IMapper<X, T> 
        where X : class 
        where T : class
    {
        X Convert(T domainSource);
        T Convert(X xmlSource);
    }
}
