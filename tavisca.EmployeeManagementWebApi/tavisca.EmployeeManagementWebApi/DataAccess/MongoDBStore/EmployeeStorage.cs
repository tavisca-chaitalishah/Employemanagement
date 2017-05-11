using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.DataAccess
{
    public class EmployeeStorage : IEmployeeStorage 
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        private IMongoCollection<Employee> _collection;

        public EmployeeStorage()
        {
            _client = new MongoClient();
            _database = _client.GetDatabase("Employee");
            _collection = _database.GetCollection<Employee>("EmployeeDatabase");
        }
        public async Task<Employee> GetByIDAsync(string employeeId)
        {
            var filter = Builders<Employee>.Filter.Eq("Id", employeeId);
            var result = await _collection.FindAsync<Employee>(filter);
            return result.First();
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            var result = await _collection.Find(x => x.Id != null).ToListAsync<Employee>();
            return result;
        }
       
        public async Task<Employee> GetByEmailAsync(string email)
        {
            var filter = Builders<Employee>.Filter.Eq("Email", email);
            var result = await _collection.FindAsync<Employee>(filter);
            return result.First();
        }

        public async Task<Employee> SaveAsync(Employee employee)
        {
           await _collection.InsertOneAsync(employee);
            return employee;
        }

        public async Task<PagedList<Employee>> GetEmployeesAsync(int pageNumber = 1, int pageSize = 20, string orderBy = "Id", SortingOrder sortingOrder = SortingOrder.DESC)
        {
            int temp = 0;
            
            var result = _collection.Find(x => x.Id != null).Limit(pageSize).Skip(temp).Sort(orderBy);

            return  new PagedList<Employee>();
        }
    }
}