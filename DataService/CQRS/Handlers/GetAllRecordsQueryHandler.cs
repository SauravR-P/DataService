using DataService.CQRS.Query;
using DataService.CQRS.Repository;
using DataService.CQRS.Service;
using DataService.Model;
using MediatR;

namespace DataService.CQRS.Handlers

{
    public class GetAllRecordsQueryHandler : IRequestHandler<GetAllRecordsQuery, IReadOnlyList<Employee>>
    {
        private IGetAllRecords _getallrecords;
        public GetAllRecordsQueryHandler(IGetAllRecords getAllRecords)
        {
            _getallrecords= getAllRecords;
        }
        public Task<IReadOnlyList<Employee>> Handle(GetAllRecordsQuery request, CancellationToken cancellationToken)
        {
            return _getallrecords.Get<Employee>();
        }
    }
}
