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

        //CREATE PERSON
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

        //GET ALL PEOPLE
        [HttpGet]
        public async Task<IActionResult> GetPersons()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetPersons();
            var response = _mapper.Map<IEnumerable<PersonResponse>>(dto);

            return Ok(response);
        }

        //GET PERSON BY ID
        [HttpGet]
        public async Task<IActionResult> GetPersonById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetPersonById(id);
            var response = _mapper.Map<PersonResponse>(dto);

            return Ok(response);
        }

        //EDIT PERSON (Should be an Admin Role)
        [HttpPut]
        public async Task<IActionResult> EditPerson(PersonEditRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var dto = _mapper.Map<PersonEditDTO>(request);

            if (await _manager.EditPerson(dto))
            {
                return StatusCode(200);
            }

            throw new Exception();
        }

        //DELETE PERSON (Should be an Admin Role)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            if (await _manager.DeletePerson(id))
            {
                return StatusCode(200);
            }
            throw new Exception();
        }
    }
}