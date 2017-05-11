using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.EnterpriseLibrary;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.Services.DataContract;
using tavisca.EmployeeManagementWebApi.Services.ServiceContract;
using tavisca.EmployeeManagementWebApi.Services.Translator;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceImplementation
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeManager _manager;

        public EmployeeService(IEmployeeManager manager)
        {
            _manager = manager;
        }
        public async Task<Employee> GetAsync(string employeeId)
        {
            try
            {

                var result =await _manager.GetAsync(employeeId);
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;
            }
        }

        public async Task<DataContract.PagedList<Employee>> GetEmployeesAsync(string pageSize, string pageNum, string orderBy, string isDescending)
        {
            try
            {
                var pagingInfo = PagingHelper.GetPagingInfo(pageSize, pageNum, orderBy, isDescending);

                var result = await _manager.GetAllAsync(pagingInfo.PageNumber, pagingInfo.PageSize, pagingInfo.OrderBy, pagingInfo.IsDescending);
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;

            }

        }

        public async Task<DataContract.PagedList<Remark>> GetRemarksAsync(string employeeId, string pageSize, string pageNum, string orderBy, string isDescending)
        {
            try
            {
                var pagingInfo = PagingHelper.GetPagingInfo(pageSize, pageNum, orderBy, isDescending);

                var result = await _manager.GetRemarksAsync(employeeId, pagingInfo.PageNumber, pagingInfo.PageSize, pagingInfo.OrderBy, pagingInfo.IsDescending);
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;
                
            }
        }
    }
}
