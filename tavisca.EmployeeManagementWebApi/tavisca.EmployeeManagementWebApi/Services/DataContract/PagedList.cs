using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.Services.DataContract
{
    [DataContract]
    public class PagedList<T>
    {
        [DataMember]
        public List<T> Results { get; set; }

        [DataMember]
        public long PageNumber { get; set; }

        [DataMember]
        public long PageSize { get; set; }

        [DataMember]
        public long TotalRecords { get; set; }

        public void ForEach(Action<T> action)
        {
            if (this.Results != null)
                this.Results.ForEach(action);
            else
                foreach (var item in this.Results)
                    action(item);
        }
    }
}
