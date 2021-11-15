using DataAccessLayer;
using DataAccessLayer.Context;
using DataAccessLayer.Entity;
using DataAccessLayer.UnifOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterKitAPI.Attributes
{
    public class LogAttribute : TypeFilterAttribute
    {
        public LogAttribute() : base(typeof(AddRandomNumberHeader2Filter))
        {
            //logRepo = logUnitOfWork.GetRepository<Log>();
        }

        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    //logRepo.Add(new Log() { Data = "test", ErrorMessage = "test message", Id= 2, ThreadId = "osef" });
        //}

        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    //logRepo.Add(new Log() { Data = "test", ErrorMessage = "test message", Id = 2, ThreadId = "osef" });
        //}

        private class AddRandomNumberHeader2Filter : IActionFilter
        {
            private IGenericRepository<Log> logRepo { get; set; }
            private IUnitOfWork<LogContext> ctx { get; set; }

            public AddRandomNumberHeader2Filter(IUnitOfWork<LogContext> logUnitOfWork)
            {
                logRepo = logUnitOfWork.GetRepository<Log>();
                ctx = logUnitOfWork;

            }
            public void OnActionExecuted(ActionExecutedContext context)
            {
                logRepo.Add(new Log() { Parameters = "test", Message = "test message", Id = 22, FileName = "osef" });
                ctx.Save();
                
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                logRepo.Add(new Log() { Parameters = "test", Message = "test message", Id = 23, FileName = "osef" });
                ctx.Save();
            }
        }
    }
}
