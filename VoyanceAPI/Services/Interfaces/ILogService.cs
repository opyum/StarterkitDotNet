using Commun.Enums;
using DataAccessLayer.Entity;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterKitAPI.Services
{
    public interface ILogService
    {

        IEnumerable<Log> GetAll();
        void Create(Log log);
        void CreateLog(SeverityEnum level,
            object item,
            string message,
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0);
    }
}
