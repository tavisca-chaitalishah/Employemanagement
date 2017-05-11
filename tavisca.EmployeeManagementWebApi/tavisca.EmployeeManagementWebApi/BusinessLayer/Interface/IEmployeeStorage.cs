using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
   public interface IEmployeeStorage
    {
        Task<Employee> SaveAsync(Employee employee);

        Task<Employee> GetByIDAsync(string employeeId);

        Task<List<Employee>> GetAllAsync();
        Task<PagedList<Employee>> GetEmployeesAsync(int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC);

        Task<Employee> GetByEmailAsync(string email);
    }
}
