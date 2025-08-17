namespace CorporateResourcesAPI.Services.Interfaces.Common
{
    public interface IBaseService<T>
    {
        Task<List<T>> ListAll();
        Task<List<T>> SearchById(int Id);
        Task<T> Create(T entity);
    }
}
