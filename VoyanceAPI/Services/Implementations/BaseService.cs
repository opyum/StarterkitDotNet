using AutoMapper;
using DataAccessLayer.Context;
using DataAccessLayer.UnifOfWork;
using Microsoft.EntityFrameworkCore;

namespace StarterKitAPI.Services
{
    public class BaseService<TContext> where TContext : DbContext
    {
        public IUnitOfWork<TContext> unitOfWork { get; set; }

        protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork<TContext> uow, IMapper mapper)
        {
            unitOfWork = uow;
            _mapper = mapper;
        }

    }
}
