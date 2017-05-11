using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Serializer;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.BusinessLogic
{
    public class CacheManager :ICacheManager
    {
        public RedisClient _client;
       public  CacheManager()
        {
            _client = new RedisClient();
        }

        public bool AddToDatabase(string employeeId, Employee employee)
        {
            
                var result= _client.Set(employeeId, JsonSerializationDeserialization.serialization(employee));
            return result;
        }

        public bool Remove(string employeeId)
        {
            return _client.Remove(employeeId);
        }

        public Employee Get(string employeeId)
        { 
            
                var result= _client.Get<Employee>(employeeId);
            return result;
        }

      
    }
}