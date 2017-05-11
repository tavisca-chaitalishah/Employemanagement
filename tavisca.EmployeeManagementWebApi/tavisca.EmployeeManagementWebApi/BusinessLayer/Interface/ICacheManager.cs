using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tavisca.EmployeeManagementWebApi.BusinessLayer.Model;

namespace tavisca.EmployeeManagementWebApi.BusinessLayer.Interface
{
    public interface ICacheManager
    {
        bool AddToDatabase(string employeeId, Employee employee);
        bool Remove(string employeeId);
        Employee Get(string employeeId);
    }

        }
