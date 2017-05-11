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
    public class EmployeeManagementService : IEmployeeManagementService
    {
        private IEmployeeManagementManager _manager;
        

        public EmployeeManagementService(IEmployeeManagementManager manager)
        {
            _manager = manager;
        }

        public async Task<Remark> AddRemarkAsync(string employeeId, Remark remark)
        {
            try
            {
                var result = await _manager.AddRemarkAsync(employeeId, remark.ToDomainModel());
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                Exception newEx;
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                throw newEx;

            }
        }

       
        public async Task<Employee> CreateAsync(Employee employee)
        {
            try
            {
                var result = await _manager.CreateAsync(EmployeeTranslator.ToDomainModel(employee));
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                Exception newEx;
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                throw newEx;

            }
        }
    }
}