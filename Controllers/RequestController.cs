using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Filters;
using StudentsAPI.Models;
using StudentsAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService requestService;

        public RequestController(IRequestService requestService)
        {
            this.requestService = requestService;
        }

        // GET: api/Events
        [HttpGet]
        public IEnumerable<Request> Get([FromQuery] Filter filter)
        {
            return requestService.Get(filter).ToList();
        }
    }
    
}
