using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CustomersAPIServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Martin Zhang", "Liam Gallagher" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Catcher Wong - {id}";
        }
    }
}
