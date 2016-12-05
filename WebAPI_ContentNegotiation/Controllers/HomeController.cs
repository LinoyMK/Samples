using System.Collections.Generic;
using System.Web.Http;
using WebAPI_ContentNegotiation.Models;

namespace WebAPI_ContentNegotiation.Controllers
{
    public class HomeController : ApiController
    {
        #region PUBLIC METHODS

        public IHttpActionResult Get()
        {
            IEnumerable<Employee> employees = GetDummyEmployee();
            return Ok(employees);
        }

        #endregion

        #region PRIVATE METHODS

        private IEnumerable<Employee> GetDummyEmployee()
        {
            return new List<Employee>() {

                new Employee() {Id = 1, Name = "Name1" },
                new Employee() {Id = 2, Name = "Name2" },
                new Employee() {Id = 3, Name = "Name3" },
                new Employee() {Id = 4, Name = "Name4" }
            };
        }

        #endregion
    }
}
