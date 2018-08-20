using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authen.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RupanugaCoreServices.SharedInterface;
using RupanugaCoreServices.SharedModels;

namespace Authen.API
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class VolunteerController : ControllerBase
    {
        private IGuestInfoServiceTypeService guestInfoServiceTypeService;
        private IGuestInfoService guestInfoService;
        private IServiceTypeService serviceTypeService;
        public VolunteerController(IGuestInfoServiceTypeService _guestInfoServiceTypeService, IGuestInfoService _guestInfoService,IServiceTypeService _serviceTypeService)
        {
            guestInfoServiceTypeService = _guestInfoServiceTypeService;
            guestInfoService = _guestInfoService;
            serviceTypeService = _serviceTypeService;
        }

        [HttpGet]
        [Route("GetMyVolunteers")]
        public IActionResult GetVolunteers()
        {
          var res=  guestInfoServiceTypeService.GetAll();
            var vmRes= JsonConvert.DeserializeObject<List<GuestInfoServiceTypeViewModel>>(JsonConvert.SerializeObject(res));
            return new OkObjectResult(vmRes);
        }

        [HttpGet]
        [Route("GetAllServiceTypes")]
        public IActionResult GetAllServiceTypes()
        {
            var res =serviceTypeService.GetAllServiceTypes();
            var vmRes = JsonConvert.DeserializeObject<List<ServiceTypeViewModel>>(JsonConvert.SerializeObject(res));
            return new OkObjectResult(vmRes);
        }

        // GET: api/Volunteer
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Volunteer/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"value you entered : {id}";
        }

        // POST: api/Volunteer
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok($"Sucessfully Registered called Post in Volunteer: {value}");
        }

        // PUT: api/Volunteer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
