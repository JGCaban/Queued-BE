﻿using AutoMapper;
using RedStarter.API.DataContract.Event;
using RedStarter.Business.DataContract.Event;
using RedStarter.Database.DataContract.Event;
using RedStarter.Database.Entities.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile()
        {
            //CREATE EVENT
            CreateMap<EventCreateRequest, EventCreateDTO>();
            CreateMap<EventCreateDTO, EventCreateRAO>();
            CreateMap<EventCreateRAO, EventEntity>();

            //GET EVENT
            CreateMap<EventEntity, EventGetListItemRAO>();
            CreateMap<EventGetListItemRAO, EventGetListItemDTO>();
            CreateMap<EventGetListItemDTO, EventResponse>();

            //EDIT EVENT
            CreateMap<EventEditRequest, EventEditDTO>();
            CreateMap<EventEditDTO, EventEditRAO>();
        }
    }
}
