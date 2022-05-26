using EmployeeModule.IdentityAuth;
using EmployeeModule.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_API.Controllers
{
    [Authorize]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public EmployeeController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/[controller]/get-employee")]
        public Response GetEmp()
        {
            var response = new Response();
            try
            {
                response.Success = true;
                response.Status = "200";
                response.Message = "success";
                response.Data = _repository.Employee.Get();
              
                return response;
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Status = "400";
                response.Message = ex.Message;

                //  var output = JsonConvert.SerializeObject(response);
                return response;
            }



        }

        [HttpGet]
        [Route("api/[controller]/get-employee-by-id")]
        public Response GetEmployeeById(int id)
        {
            var response = new Response();
            try
            {

                response.Success = true;
                response.Status = "200";
                response.Message = "success";
                response.Data = _repository.Employee.GetById(id);

                return response;
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Status = "400";
                response.Message = ex.Message;

                //  var output = JsonConvert.SerializeObject(response);
                return response;
            }

        }

        [HttpGet]
        [Route("api/[controller]/get-employee-by-dept")]
        public Response GetEmployeeByDept(int id)
        {
            var response = new Response();
            try
            {

                response.Success = true;
                response.Status = "200";
                response.Message = "success";
                response.Data = _repository.Employee.GetByDept(id);

                return response;
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Status = "400";
                response.Message = ex.Message;

                //  var output = JsonConvert.SerializeObject(response);
                return response;
            }

        }

        [HttpPost]
        [Route("api/[controller]/create-employee")]
        public Response CreateAnnual([FromBody] JObject data)
        {
            var response = new Response();
            try
            {
                var result = _repository.Employee.CreateAndUpdate(data);

                if (result == 1)
                {
                    response.Success = true;
                    response.Status = "200";
                    response.Message = "success";
                    response.Data = result;
                 
                    return response;
                }
                else
                {

                
                    response.Success = false;
                    response.Status = "400";
                    response.Message = "error";
                    response.Data = result;
                
                    return response;
                }
            }
            catch (Exception ex)
            {

                response.Success = false;
                response.Status = "500";
                response.Message = ex.Message;

                //  var output = JsonConvert.SerializeObject(response);
                return response;
            }

        }

    }
}
