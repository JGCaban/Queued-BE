﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Database.DataContract.Event
{
    public interface IEventRepository
    {
        Task<bool> CreateEvent(EventCreateRAO rao);
        Task<IEnumerable<EventGetListItemRAO>> GetEvents();
        Task<EventGetListItemRAO> GetEventById(int id);
        Task<bool> EditEvent(EventEditRAO rao);
        Task<bool> DeleteEvent(int id);
    }
}
