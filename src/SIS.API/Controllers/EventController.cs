using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Event;
using RedStarter.Business.DataContract.Event;

namespace RedStarter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEventManager _manager;

        public EventController(IMapper mapper, IEventManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        //CREATE EVENT
        [HttpPost]
        public async Task<IActionResult> PostEvent(EventCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }
            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = _mapper.Map<EventCreateDTO>(request);
            dto.DateCreated = DateTime.Now;
            dto.OwnerID = identityClaimNum;

            if (await _manager.CreateEvent(dto))
                return StatusCode(201);

            throw new Exception();
        }

        //GET ALL EVENTS
        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetEvents();
            var response = _mapper.Map<IEnumerable<EventResponse>>(dto);

            return Ok(response);
        }

        //GET EVENT BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var dto = await _manager.GetEventById(id);
            var response = _mapper.Map<EventResponse>(dto);

            return Ok(response);
        }

        //EDIT EVENT (Should be an Admin Role)
        [HttpPut]
        public async Task<IActionResult> EditEvent(EventEditRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var dto = _mapper.Map<EventEditDTO>(request);

            if (await _manager.EditEvent(dto))
            {
                return StatusCode(200);
            }
            throw new Exception();
        }

        //DELETE EVENT (Should be an Admin Role)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            if (await _manager.DeleteEvent(id))
            {
                return StatusCode(200);
            }
            throw new Exception();
        }
    }
}