using System.Linq;
using Authen.Factory;
using Authen.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RupanugaCoreServices.SharedInterface;
using RupanugaCoreServices.SharedModels;

namespace Authen.Accounts
{
    [Route("api/[controller]")]
    //[ApiController]    
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly RupanugaOKCDBContext _OKCContext;
        private readonly IEventService eventService;

        //public AccountsController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext appDbContext)
        //{
        //    _userManager = userManager;
        //    _mapper = mapper;
        // _appDbContext = appDbContext;
        //}
        public AccountsController(IEventService _eventService)
        {
            //_OKCContext = oKCContext;
            eventService = _eventService;
            //_userManager = userManager;
            //_mapper = mapper;
            //_appDbContext = appDbContext;
        }

        //// POST api/accounts
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody]RegistrationViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var userIdentity = _mapper.Map<AppUser>(model);

        //    var result = await _userManager.CreateAsync(userIdentity, model.Password);

        //    if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

        //    await _appDbContext.Customers.AddAsync(new Customer { IdentityId = userIdentity.Id, Location = model.Location });
        //    await _appDbContext.SaveChangesAsync();

        //    return new OkObjectResult("Account created");
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
       // [Route("TestGet")]
        public IActionResult TestGet(int id)
        {
            // var evnt =_appDbContext.Events.FirstOrDefault(x => x.Eventd == 1);
           // var context = new ISKCON_OKCContext();
            var evnt = eventService.GetEventByID(id);
            
            return new OkObjectResult(evnt);
        }
    }
}