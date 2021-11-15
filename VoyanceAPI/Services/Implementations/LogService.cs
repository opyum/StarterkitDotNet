using AutoMapper;
using Commun.Enums;
using DataAccessLayer;
using DataAccessLayer.Context;
using DataAccessLayer.Entity;
using DataAccessLayer.UnifOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Runtime;
namespace StarterKitAPI.Services
{
    public class LogService : BaseService<LogContext>, ILogService
    {
        private IGenericRepository<Log> _logRepo { get; set; }
        private readonly IConfigurationRoot _configuration;

        public LogService(IUnitOfWork<LogContext> uow, IMapper mapper) : base(uow, mapper)
        {
            _logRepo = unitOfWork.GetRepository<Log>();
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }
        public async void Create(Log log)
        {
            _logRepo.AddAsync(log);
            unitOfWork.Save();
        }
        public void CreateLog(SeverityEnum level, object item, string message,
                    [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            SeverityEnum logLevelParam = ToEnum(_configuration["LogLevel"]);
            //On compare le log level dans le appsettings et celui en paramètre
            if (level <= logLevelParam)
            {
                Log log = new Log()
                {
                    Parameters = JsonSerializer.Serialize(item),
                    Message = message,
                    FileName = sourceFilePath,
                    Line = sourceLineNumber,
                };
                _logRepo.AddAsync(log);
                unitOfWork.Save();
            }
        }

        private SeverityEnum ToEnum(string logLevelString)
        {
            var retour = Enum.GetValues(typeof(SeverityEnum)).Cast<SeverityEnum>().FirstOrDefault(x => x.ToString() == logLevelString);
            return retour;
        }

        public IEnumerable<Log> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}