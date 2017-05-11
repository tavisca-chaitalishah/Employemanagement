using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.Services.DataContract;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceContract
{
  
    public interface IIdentityService
    {
       
        Task<Employee> AuthenticateAsync(Credential credential);
        
        Task<bool> ChangePasswordAsync(ChangePasswordRequest request);
    }
}
