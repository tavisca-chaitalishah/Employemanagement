using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.Services.Translator
{
   public static class EmployeeTranslator
    {
        public static BusinessLayer.Model.Employee ToDomainModel(this Services.Employee employee)
        {
            if (employee == null) return null;
            return new BusinessLayer.Model.Employee()
            {
                Id = employee.Id,
                Title = employee.Title,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                JoiningDate = employee.JoiningDate,
                Phone = employee.Phone,
               // Roles = employee.Roles
            };
        }
        public static Services.Employee ToDataContract(this BusinessLayer.Model.Employee employee)
        {
            if (employee == null) return null;
            return new Services.Employee()
            {
                Id = employee.Id,
                Title = employee.Title,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                JoiningDate = employee.JoiningDate,
                Phone = employee.Phone,
             //   Roles = employee.Roles
            };
        }

    }
}
