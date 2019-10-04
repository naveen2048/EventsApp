using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EventInfo.Business;
using EventInfo.Business.Dtos;
using EventInfo.Data.Entities;

namespace EventInfo.Business
{
    public class AutoMapping:IAutoMapper
    {
        private static IMapper _mapper;
        private static MapperConfiguration _config;


        public IMapper Mapper
        {
            get
            {
                if (_mapper == null)
                {
                    AutoMapperRegistration();
                }
                return _mapper;
            }
        }
        public AutoMapping() => AutoMapperRegistration();
        private void AutoMapperRegistration()
        {
            if(_config!=null) return;

            _config=new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventDto>();
               // cfg.CreateMap<EventType, EventType>();
                cfg.CreateMap<Country, CountryDto>();
                cfg.CreateMap<City, CityDto>();

            });
            _mapper = _config.CreateMapper();
        }

        public T2 Map<T1, T2>(T1 input)
        {
          AutoMapperRegistration();
          return Mapper.Map<T1, T2>(input);
        }

        public IEnumerable<T2> Map<T1, T2>(IEnumerable<T1> input)
        {
            AutoMapperRegistration();
            return Mapper.Map<IEnumerable<T1>, IEnumerable<T2>>(input);
        }
    }
}
