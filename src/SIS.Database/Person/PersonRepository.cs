using AutoMapper;
using RedStarter.Database.Contexts;
using RedStarter.Database.DataContract.Person;
using RedStarter.Database.Entities.Person;
using System;
using System.Collections.Generic;
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


        public async Task<bool> CreatePerson(PersonCreateRAO rao)
        {
            var entity = _mapper.Map<PersonEntity>(rao);

            await _context.PersonTableAccess.AddAsync(entity);
            return await _context.SaveChangesAsync() == 1;

        }
    }
}
