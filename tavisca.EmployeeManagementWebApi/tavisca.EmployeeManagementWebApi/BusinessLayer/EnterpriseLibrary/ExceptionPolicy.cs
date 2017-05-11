using System;
using EntLib = Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.EnterpriseLibrary
{
   public class ExceptionPolicy 
    {
        public static bool HandleException(string policy, Exception ex)
        {
            return EntLib.ExceptionPolicy.HandleException(ex, policy);
        }

        public static bool HandleException(string policy, Exception ex, out Exception newEx)
        {
            return EntLib.ExceptionPolicy.HandleException(ex, policy, out newEx);
        }
    }
}