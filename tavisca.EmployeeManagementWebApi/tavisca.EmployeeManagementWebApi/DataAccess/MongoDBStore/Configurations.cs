using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.DataAccess.MongoDBStore
{
    internal static class Configurations
    {
        internal static string EmployeeDbConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["employeedb"].ConnectionString;
            }
        }
    }
}