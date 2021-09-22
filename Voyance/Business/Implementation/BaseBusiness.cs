using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Business
{
    public class BaseBusiness
    {
        protected readonly IMapper Mapper;

        public BaseBusiness(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}
