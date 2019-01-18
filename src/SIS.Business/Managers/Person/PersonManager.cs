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


        //CREATE PERSON
        public async Task<bool> CreatePerson(PersonCreateDTO dto)
        {
            var rao = _mapper.Map<PersonCreateRAO>(dto);

           if(await _repository.CreatePerson(rao))
            return true;

            throw new NotImplementedException();
        }

        //GET ALL PEOPLE
        public async Task<IEnumerable<PersonGetListItemDTO>> GetPersons()
        {
            var rao = await _repository.GetPersons();
            var dto = _mapper.Map<IEnumerable<PersonGetListItemDTO>>(rao);

            return dto;
        }

        //GET PERSON BY ID
        public async Task<PersonGetListItemDTO> GetPersonById(int id)
        {
            var rao = await _repository.GetPersonById(id);
            var dto = _mapper.Map<PersonGetListItemDTO>(rao);

            return dto;
        }

        //EDIT PERSON
        public async Task<bool> EditPerson(PersonEditDTO dto)
        {
            var rao = _mapper.Map<PersonEditRAO>(dto);

            if  (await _repository.EditPerson(rao))
            {
                return true;
            }
            return false;
        }

        //DELETE PERSON
        public async Task<bool> DeletePerson(int id)
        {
            await _repository.DeletePerson(id);

            return true;
        }
    }
}
