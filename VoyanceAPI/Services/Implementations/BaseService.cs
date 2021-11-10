using AutoMapper;
using DataAccessLayer.Context;
using DataAccessLayer.UnifOfWork;

namespace StarterKitAPI.Services
{
    public class BaseService
    {
        public IUnitOfWork<SqliteContext> unitOfWorkSqlite { get; set; }
        public IUnitOfWork<LogContext> unitOfWorkLog { get; set; }
        protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork<SqliteContext> uow, IUnitOfWork<LogContext> logUnitOfWork, IMapper mapper)
        {
            unitOfWorkSqlite = uow;
            unitOfWorkLog = logUnitOfWork;
            _mapper = mapper;
        }

    }
}
