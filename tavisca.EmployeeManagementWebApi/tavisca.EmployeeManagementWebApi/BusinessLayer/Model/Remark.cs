using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Model
{
    public class Remark
    {
        public string Text { get; set; }

        public DateTime CreateTimeStamp { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Text))
                throw new Exception("Text cannot be null or empty.");
        }
    }
}
