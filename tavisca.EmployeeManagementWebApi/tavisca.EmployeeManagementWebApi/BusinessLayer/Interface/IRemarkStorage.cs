using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
    public interface IRemarkStorage
    {
        Task<Remark> AddRemarkAsync(string employeeId, Remark remark);

        Task<PagedList<Remark>> GetRemarksAsync(string employeeId, int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC);
    }
}