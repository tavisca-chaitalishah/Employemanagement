using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.Services.DataContract
{
    [DataContract]
    public class ChangePasswordRequest
    {
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string OldPassword { get; set; }
        [DataMember]
        public string NewPassword { get; set; }
    }
}