using AutoMapper;
using RedStarter.Business.DataContract.Event;
using RedStarter.Database.DataContract.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RedStarter.Business.Managers.Event
{
    public class EventManager : IEventManager
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _repository;

        public EventManager(IMapper mapper, IEventRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        //CREATE EVENT
        public async Task<bool> CreateEvent(EventCreateDTO dto)
        {
            var rao = _mapper.Map<EventCreateRAO>(dto);

            if(await _repository.CreateEvent(rao))
                return true;

            throw new NotImplementedException();
        }

        //GET ALL EVENTS
        public async Task<IEnumerable<EventGetListItemDTO>> GetEvents()
        {
            var rao = await _repository.GetEvents();
            var dto = _mapper.Map<IEnumerable<EventGetListItemDTO>>(rao);

            return dto;
        }

        //GET EVENT BY ID
        public async Task<EventGetListItemDTO> GetEventById(int id)
        {
            var rao = await _repository.GetEventById(id);
            var dto = _mapper.Map<EventGetListItemDTO>(rao);

            return dto;
        }

        //EDIT EVENT
        public async Task<bool> EditEvent(EventEditDTO dto)
        {
            var rao = _mapper.Map<EventEditRAO>(dto);

            if (await _repository.EditEvent(rao))
            {
                return true;
            }
            return false;
        }

        //DELETE EVENT
        public async Task<bool> DeleteEvent(int id)
        {
            await _repository.DeleteEvent(id);

            return true;
        }
    }
}
