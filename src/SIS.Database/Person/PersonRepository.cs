using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Person;
using RedStarter.Database.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.Person
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public PersonRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //CREATE PERSON
        public async Task<bool> CreatePerson(PersonCreateRAO rao)
        {
            var entity = _mapper.Map<PersonEntity>(rao);
            await _context.PersonTableAccess.AddAsync(entity);
            return await _context.SaveChangesAsync() == 1;
        }

        //GET ALL PERSONS
        public async Task<IEnumerable<PersonGetListItemRAO>> GetPersons()
        {
            var query = await _context.PersonTableAccess.ToArrayAsync();
            var array = _mapper.Map<IEnumerable<PersonGetListItemRAO>>(query);

            return array;
        }

        //GET PERSON BY ID
        public async Task<PersonGetListItemRAO> GetPersonById(int id)
        {
            var query = _context.PersonTableAccess.Single(x => x.PersonEntityId == id);
            var rao = _mapper.Map<PersonGetListItemRAO>(query);

            return rao;
        }

        //EDIT PERSON
        public async Task<bool> EditPerson(PersonEditRAO rao)
        {
            var entity = _context.PersonTableAccess.Single(x => x.PersonEntityId == rao.PersonEntityId);
            entity.FirstName = rao.FirstName;
            entity.LastName = rao.LastName;
            entity.Phone = rao.Phone;

            return await _context.SaveChangesAsync() == 1;
        }

        //DELETE PERSON
        public async Task<bool> DeletePerson(int id)
        {
            var entity = await _context.PersonTableAccess.SingleAsync(x => x.PersonEntityId == id);
            _context.PersonTableAccess.Remove(entity);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
