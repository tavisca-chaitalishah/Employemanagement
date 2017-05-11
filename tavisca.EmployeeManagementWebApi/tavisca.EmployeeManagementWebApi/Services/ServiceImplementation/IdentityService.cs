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
    public class IdentityService : IIdentityService
    {
        public IIdentityManager _manager;
        public IdentityService(IIdentityManager manager)
        {
            _manager = manager;
        }


        public async Task<Employee> AuthenticateAsync(Credential credential)
        {
            try
            {
                var result = await _manager.AuthenticateAsync(CredentialTranslator.ToDomainModel(credential));
                if (result == null) return null;
                return result.ToDataContract();
            }
            catch (Exception ex)
            {
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex);
                if (rethrow) throw;
                return null;
               
            }
        }

        public async Task<bool> ChangePasswordAsync(DataContract.ChangePasswordRequest request)
        {
            try
            {
                return await _manager.ChangePasswordAysnc(request.Email, request.OldPassword, request.NewPassword);
            }
            catch (Exception ex)
            {
                Exception newEx;
                var rethrow = ExceptionPolicy.HandleException("service.policy", ex, out newEx);
                return false;
                
            }
        }
    }
}
