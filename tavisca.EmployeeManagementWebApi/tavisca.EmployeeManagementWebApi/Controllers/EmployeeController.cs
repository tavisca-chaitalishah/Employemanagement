using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.Services.Translator;
using tavisca.EmployeeManagementWebApi.DataAccess;
using tavisca.EmployeeManagementWebApi.Services;
using tavisca.EmployeeManagementWebApi.Services.DataContract;
using tavisca.EmployeeManagementWebApi.Services.ServiceContract;

namespace tavisca.EmployeeManagementWebApi.Controllers
{

    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private IEmployeeStorage _employeeStore;
        private IEmployeeService _service;
        private IEmployeeManagementManager _manager;

        public EmployeeController(IEmployeeManagementManager manager, IEmployeeService service)
        {
            //_employeeStore = new EmployeeStorage();

            _manager = manager;
            _service = service;           
        }
      //  GET: api/employee

        //public async Task<List<Employee>> Get()
        //{
        //    var result = await _employeeStore.GetAllAsync();
        //    return result;

        //}

        // GET: api/employee/5
        [HttpGet()]
        [Route("employee/{id}")]
        public async Task<Employee> GetbyID(string id)
        {

            var result = await _service.GetAsync(id);
          //  var result = await _employeeStore.GetByIDAsync(id);
            return result;

        }

        [HttpGet()]
        [Route("Employee/{pageSize}/{pageNumber}/{sortBy}/{orderBy}")]
        public async Task GetAllEmployees(string pageSize, string pageNumber, string sortBy, string orderBy)
        {
            var result = await _service.GetEmployeesAsync(pageNumber, pageSize, sortBy, orderBy);
        }


        [HttpGet()]
        [Route("employee/{employeeId}/remark/pSize={pageSize}/pNum={pageNumber}/sortBy/{orderBy}/isDesc={isDescending}")]
        public async Task GetRemarks(string employeeId, string pageSize, string pageNumber, string orderBy, string isDescending)
        {

        }
        //[HttpGet()]
        //[Route("{email}")]
        //// GET: api/employee/Email/shahchaitali29@gmail.com
        //public async Task<Employee> SearchByEmail(string email)
        //{
        //    var result = await _employeeStore.GetByEmailAsync(email);
        //    return result;
        //}

        // POST: api/employee
        public void Post([FromBody]Employee value)
        {

        }



        public async Task Put([FromBody]Employee value)
        {
            await _manager.CreateAsync(value.ToDomainModel());
        }

        // DELETE: api/employee/5
        public void Delete(int id)
        {
        }

    }
}
