using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using EmployeeModule.DbContext;
using EmployeeModule.Models;
using EmployeeModule.IRepository;

namespace LMS_API.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected AppDbContext _dataContext;

        public EmployeeRepository(AppDbContext context)
        {

            this._dataContext = context;
 
        }

        public List<Employee> Get()
        {
            
            var result =  _dataContext.Employee.Where(s => s.IsActive == true).ToList();
            return result;      
        }


        public List<Employee> GetById(int Id)
        {

            return _dataContext.Employee.Where(s => s.Id == Id &&  s.IsActive == true).ToList();
        }

        public List<Employee> GetByDept(int Id)
        {

            return _dataContext.Employee.Where(s => s.DeptId == Id && s.IsActive == true).ToList();
        }


        public dynamic CreateAndUpdate(JObject data)
        {

           
            
            try
            {
                dynamic result;
                dynamic response = "";
                if (int.Parse((string)data["Id"]) == 0  )
                {
                    var Data = JsonConvert.DeserializeObject<Employee>(data.ToString());

                    _dataContext.Employee.Add(Data);
                     response = _dataContext.SaveChanges();
                  
                }
                else
                {
                    result = _dataContext.Employee.FirstOrDefault(s => s.Id == int.Parse((string)data["Id"]));
                    if (result != null)
                    {

                        data["UpdatedOn"] = DateTime.Parse(DateTime.Now.ToString());
                        var Data = JsonConvert.DeserializeObject<Employee>(data.ToString());


                        _dataContext.Entry<Employee>(result).CurrentValues.SetValues(Data);
                        response = _dataContext.SaveChanges();

                       
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

    }
}
