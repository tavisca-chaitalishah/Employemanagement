using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
    public interface IEmployeeManagementManager
    {
        Task<Employee> CreateAsync(Employee employee);

        Task<Remark> AddRemarkAsync(string employeeId, Remark remark);
    }
}

