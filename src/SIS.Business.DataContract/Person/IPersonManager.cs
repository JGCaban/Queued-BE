using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.DataContract.Person
{
    public interface IPersonManager
    {
        Task<bool> CreatePerson(PersonCreateDTO dto);
    }
}
