using AutoMapper;
using RedStarter.API.DataContract.Person;
using RedStarter.Business.DataContract.Person;
using RedStarter.Database.DataContract.Person;
using RedStarter.Database.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedStarter.API.MappingProfiles
{
    public class PersonMappingProfile : Profile
    {
        public PersonMappingProfile()
        {
            //CREATE EVENT
            CreateMap<PersonCreateRequest, PersonCreateDTO>();
            CreateMap<PersonCreateDTO, PersonCreateRAO>();
            CreateMap<PersonCreateRAO, PersonEntity>();

            //GET EVENT
            CreateMap<PersonEntity, PersonGetListItemRAO>();
            CreateMap<PersonGetListItemRAO, PersonGetListItemDTO>();
            CreateMap<PersonGetListItemDTO, PersonResponse>();
        }

            //EDIT EVENT
            CreateMap<PersonEditRequest, PersonEditDTO>();
            CreateMap<PersonEditDTO, PersonEditRAO>();
    }
}
