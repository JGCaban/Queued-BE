using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Person;
using RedStarter.Business.DataContract.Person;

namespace RedStarter.API.Controllers.Person
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonManager _manager;

        public PersonController(IMapper mapper, IPersonManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        //CREATE EVENT
        [HttpPost]
        public async Task<IActionResult> PostPerson(PersonCreateRequest request)
        {
            if (!ModelState.IsValid) 
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);



            var dto = _mapper.Map<PersonCreateDTO>(request);
            dto.DateCreated = DateTime.Now;

            if(await _manager.CreatePerson(dto))
            return StatusCode(201);

            throw new Exception();
        }
    }
}