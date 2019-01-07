using RedStarter.Business.DataContract.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Event
{
    public class EventManager : IEventManager
    {
        public Task<bool> CreateEvent(EventCreateDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
