using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Model
{
    public class PagedList<T> : List<T>
    {
        public long PageNumber { get; set; }

        public long PageSize { get; set; }

        public long TotalRecords { get; set; }

        public new void ForEach(Action<T> action)
        {
            var list = this as List<T>;
            if (list != null)
                list.ForEach(action);
            else
                foreach (var item in this)
                    action(item);
        }
    }
}
