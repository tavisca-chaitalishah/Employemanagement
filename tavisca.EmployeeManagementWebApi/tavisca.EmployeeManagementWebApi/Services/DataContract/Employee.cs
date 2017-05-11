using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.Services
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public DateTime JoiningDate { get; set; }

        [DataMember]
        public List<string> Roles { get; set; }
    }
}
