using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalFilters.Infrastructure
{
    public class ProfileAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            timer.Stop();
            string message = $"На выполнение метода {context.ActionDescriptor.DisplayName} затрачено {timer.Elapsed}";

            StreamWriter streamWriter = new StreamWriter("App_Data/log.txt", true);
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }
    }
}
