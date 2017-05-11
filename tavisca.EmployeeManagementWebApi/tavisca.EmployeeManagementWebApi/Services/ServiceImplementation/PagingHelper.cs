using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.Services.ServiceImplementation
{
    internal static class PagingHelper
    {
        internal static dynamic GetPagingInfo(string pSize, string pNum, string orderBy, string isDesc)
        {
            int pageSize, pageNumber = 0;
            bool isDescending;
                pageSize = 20;

            if (string.IsNullOrWhiteSpace(pNum) || int.TryParse(pNum, out pageNumber) == false)
                pageNumber = 1;

            if (string.IsNullOrWhiteSpace(isDesc) || bool.TryParse(isDesc, out isDescending) == false)
                isDescending = false;

            return new { PageSize = pageSize, PageNumber = pageNumber, OrderBy = orderBy, IsDescending = isDescending };
        }
    }
}