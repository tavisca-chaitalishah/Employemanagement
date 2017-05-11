using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.Services.DataContract;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceContract
{
    public interface IEmployeeService
    {
        Task<Employee> GetAsync(string employeeId);
        Task<PagedList<Employee>> GetEmployeesAsync(string pageSize, string pageNumber, string orderBy, string isDescending);

        Task<PagedList<Remark>> GetRemarksAsync(string employeeId, string pageSize, string pageNumber, string orderBy, string isDescending);
    }
}
