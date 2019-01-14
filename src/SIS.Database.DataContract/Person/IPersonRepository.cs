using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Person
{
    public interface IPersonRepository
    {
        Task<bool> CreatePerson(PersonCreateRAO rao);
        Task<IEnumerable<PersonGetListItemRAO>> GetPersons();
        Task<PersonGetListItemRAO> GetPersonById(int id);
        Task<bool> EditPerson(PersonEditRAO dto);
        Task<bool> DeletePerson(int id);
    }
}
