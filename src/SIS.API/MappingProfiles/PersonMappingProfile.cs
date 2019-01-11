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
            CreateMap<PersonCreateRequest, PersonCreateDTO>();
            CreateMap<PersonCreateDTO, PersonCreateRAO>();
            CreateMap<PersonCreateRAO, PersonEntity>();
        }
    }
}
