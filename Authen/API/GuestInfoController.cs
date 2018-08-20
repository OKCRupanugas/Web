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
    [Route("api/GuestInfo")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class GuestInfoController : ControllerBase
    {
        private IGuestInfoService guestInfoService;

        public GuestInfoController(IGuestInfoService _guestInfoService)
        {            
            guestInfoService = _guestInfoService;
        }
       


        // GET: api/GuestInfo/5
        [HttpGet("{id}", Name = "GetGuest")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GuestInfo
        [HttpPost]
        //[Route("Register")]
        public IActionResult Post([FromBody] GuestInfoViewModel model)
        {
            var vmRes = JsonConvert.DeserializeObject<GuestInfo>(JsonConvert.SerializeObject(model));
            var guest =guestInfoService.Register(vmRes);

            string msg = "There was an error registering, Please try again";

            if (guest != null)
            {
                msg = $"Sucessfully Registered {guest.FirstName}  {guest.LastName}";
                return Ok(msg);
            }
            else
                return BadRequest(msg);            

        }

        // PUT: api/GuestInfo/5
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
