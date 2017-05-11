using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.BusinessLogic
{
    public class EmployeeManagementManager : IEmployeeManagementManager
    {
        private IEmployeeStorage _storage;
        IRemarkStorage _remarkStorage;
        ICacheManager _cManager;
        public EmployeeManagementManager(IEmployeeStorage storage, IRemarkStorage remarkStorage, ICacheManager cManager)
        {
            _storage = storage;
            _remarkStorage = remarkStorage;
            _cManager = cManager;
        }

        public async Task<Remark> AddRemarkAsync(string employeeId, Remark remark)
        {
            remark.Validate();
            remark.CreateTimeStamp = DateTime.UtcNow;
            return await _remarkStorage.AddRemarkAsync(employeeId, remark);
        }

      async Task<Employee> IEmployeeManagementManager.CreateAsync(Employee employee)
        {
            employee.Validate();
            employee.Id = Guid.NewGuid().ToString();
            employee.Password = "p@ssw0rd";
            _cManager.AddToDatabase(employee.Id, employee);
                return await _storage.SaveAsync(employee);
           
        }

       
    }
}