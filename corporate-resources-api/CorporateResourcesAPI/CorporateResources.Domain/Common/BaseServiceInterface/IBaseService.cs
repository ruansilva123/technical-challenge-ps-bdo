using CorporateResources.Communication.Responses;

namespace CorporateResources.Domain.Common.BaseServiceInterface
{
    public interface IBaseService<T>
    {
        Task<GenericResponse<List<T>>> ListAll();
        Task<GenericResponse<List<T>>> SearchById(int Id);
        Task<GenericResponse<T>> Create(T entity);
    }
}
