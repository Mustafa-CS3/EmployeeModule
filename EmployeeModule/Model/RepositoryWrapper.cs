using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using EmployeeModule.DbContext;
using EmployeeModule.IRepository;
using LMS_API.Models;

namespace EmployeeModule.Models
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AppDbContext _repoContext;
        private IEmployeeRepository _employee;
     
       
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employee == null)
                {
                    _employee = new EmployeeRepository(_repoContext);
                }
                return _employee;
            }
        }
       
        public RepositoryWrapper(AppDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
