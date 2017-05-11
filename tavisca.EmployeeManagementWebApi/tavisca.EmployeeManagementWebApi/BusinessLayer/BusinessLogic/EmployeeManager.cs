using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.BusinessLogic
{
    public class EmployeeManager : IEmployeeManager
    {
        ICacheManager _cManager;
        public EmployeeManager(IEmployeeStorage storage, IRemarkStorage remarkStorage, ICacheManager cManager)
        {
            _storage = storage;
            _remarkStorage = remarkStorage;
            _cManager = cManager;
        }

       private IEmployeeStorage _storage;
        private IRemarkStorage _remarkStorage;

        public async Task<Employee> GetAsync(string employeeId)
        {
            Employee emp = _cManager.Get(employeeId);
            if (emp == null)
            {
               emp =  await _storage.GetByIDAsync(employeeId);
                _cManager.AddToDatabase(employeeId, emp);
            }
           
            return emp;
        }

        public async Task<PagedList<Employee>> GetAllAsync(int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC)
        {
            throw new NotImplementedException();
        }

        public async Task<PagedList<Remark>> GetRemarksAsync(string employeeId, int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC)
        {
            return await _remarkStorage.GetRemarksAsync(employeeId, pageNumber, pageSize, orderBy, sortingOrder);
        }
    }
}