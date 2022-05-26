
using EmployeeModule.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModule.IRepository
{
    public interface IEmployeeRepository
    {
        List<Employee> Get();

        dynamic CreateAndUpdate(JObject values);

        List<Employee> GetById(int Id);

        List<Employee> GetByDept(int Id);


    }
}
