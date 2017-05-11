using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.Services.DataContract;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceContract
{
    public interface IEmployeeManagementService
    {
        Task<Employee> CreateAsync(Employee employee);
        Task<Remark> AddRemarkAsync(string employeeId, Remark remark);
    }
}
