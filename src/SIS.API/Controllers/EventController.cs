﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RedStarter.API.DataContract.Event;
using RedStarter.Business.DataContract.Event;

namespace RedStarter.API.Controllers
{
    [AllowAnonymous]
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

        [HttpPost]
        public async Task<IActionResult> PostEvent(EventCreateRequest request)
        {
            var dto = _mapper.Map<EventCreateDTO>(request);
            dto.DateCreated = DateTime.Now;

           await _manager.CreateEvent(dto);

            //Pass DTO to Bussiness Layer/Manager

            return Ok();
        }
    }
}