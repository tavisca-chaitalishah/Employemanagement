using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.Services.Translator
{
    public static class CredentialTranslator
    {
        public static BusinessLayer.Model.Credential ToDomainModel(this DataContract.Credential credential)
        {
            if (credential == null) return null;
            return new BusinessLayer.Model.Credential()
            {
                Email = credential.Email,
                Password = credential.Password
            };
        }

        public static DataContract.Credential ToDataContract(this BusinessLayer.Model.Credential credential)
        {
            if (credential == null) return null;
            return new DataContract.Credential()
            {
                Email = credential.Email,
                Password = credential.Password
            };
        }
    }
}
