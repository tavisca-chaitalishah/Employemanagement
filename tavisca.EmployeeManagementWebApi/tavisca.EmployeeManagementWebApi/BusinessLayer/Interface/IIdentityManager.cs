using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
    public interface IIdentityManager
    {
        Task<Employee> AuthenticateAsync(Credential credential);

        Task<bool> ChangePasswordAysnc(string email, string oldPassword, string newPassword);
    }
}
