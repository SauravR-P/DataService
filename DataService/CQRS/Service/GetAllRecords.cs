using DataService.CQRS.Repository;
using DataService.Model;
using Microsoft.EntityFrameworkCore;

namespace DataService.CQRS.Service
{
    public class GetAllRecords : IGetAllRecords
    {
        private EmployeeDbContext _employeeDbContext;
        public GetAllRecords(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
           
        }
        public async Task<IReadOnlyList<T>> Get<T>()
        {
            try
            {
                var result = await _employeeDbContext.Employee.ToListAsync();
                if (result != null)
                {
                    return (IReadOnlyList<T>)result;
                }
                else return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
