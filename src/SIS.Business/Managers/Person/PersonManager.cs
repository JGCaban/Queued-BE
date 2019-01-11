using AutoMapper;
using RedStarter.Business.DataContract.Person;
using RedStarter.Database.DataContract.Person;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Person
{
    public class PersonManager : IPersonManager
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _repository;

        public PersonManager(IMapper mapper, IPersonRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public async Task<bool> CreatePerson(PersonCreateDTO dto)
        {
            var rao = _mapper.Map<PersonCreateRAO>(dto);

           if(await _repository.CreatePerson(rao))
            return true;

            throw new NotImplementedException();
        }
    }
}
