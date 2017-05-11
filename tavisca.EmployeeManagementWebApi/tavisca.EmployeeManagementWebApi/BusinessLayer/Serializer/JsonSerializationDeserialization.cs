using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Interface;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Serializer
{
    public static class JsonSerializationDeserialization
    {
        public static byte[] serialization(Employee employee)
        {
            var serializeString = JsonConvert.SerializeObject(employee);
            return System.Text.Encoding.UTF8.GetBytes(serializeString);
        }

        public static Employee DeserializeData(byte[] employeeData)
        {
            var deserializeString = System.Text.Encoding.UTF8.GetString(employeeData);
            var employeeList = JsonConvert.DeserializeObject<Employee>(deserializeString);
            return employeeList;
        }
    }
}
