using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.DataAccess.MongoDBStore
{
    public class RemarkStorage : IRemarkStorage
    {
        public RemarkStorage()
        {
            
        }
        public Task<Remark> AddRemarkAsync(string employeeId, Remark remark)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<Remark>> GetRemarksAsync(string employeeId, int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC)
        {
            throw new NotImplementedException();
        }
    }
}