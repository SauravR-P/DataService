using System.Threading.Tasks;

namespace DataService.CQRS.Repository
{
    public interface IGetAllRecords
    {
        Task<IReadOnlyList<T>> Get<T>();
    }
}
