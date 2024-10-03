namespace CrudRepository.Implementations
{
    public interface IIdentifiable<TId>
    {
        TId Id { get; }
    }
}