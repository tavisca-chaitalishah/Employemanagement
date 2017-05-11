using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
    public interface IEmployeeManager
    {
        Task<Employee> GetAsync(string employeeId);

        Task<PagedList<Employee>> GetAllAsync(int pageNumber = 1, int pageSize = 20, string orderBy = "Id", Model.SortingOrder sortingOrder = Model.SortingOrder.DESC);

        Task<PagedList<Remark>> GetRemarksAsync(string employeeId, int pageNumber = 1, int pageSize = 20, string orderBy = "Id", Model.SortingOrder sortingOrder = Model.SortingOrder.DESC);
    }
}