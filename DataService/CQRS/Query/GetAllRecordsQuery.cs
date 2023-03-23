using DataService.Model;
using MediatR;
namespace DataService.CQRS.Query
{
    public class GetAllRecordsQuery : IRequest<IReadOnlyList<Employee>>
    {
    }
}
