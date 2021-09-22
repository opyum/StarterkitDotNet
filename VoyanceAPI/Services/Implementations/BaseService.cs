using AutoMapper;
using DataAccessLayer.UnifOfWork;

namespace VoyanceApi.Services
{
    public class BaseService
    {
        public IUnitOfWork unitOfWork { get; set; }
        protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork uow, IMapper mapper)
        {
            unitOfWork = uow;
            _mapper = mapper;
        }

    }
}
