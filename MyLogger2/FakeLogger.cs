using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyLogger2.Models;

namespace MyLogger2
{
    public class FakeLogger : ILogger
    {
        public void LogInfoEvent(Exception ex, string functionName = "n/a")
        {

        }

        public void LogInfoEvent(string message, string functionName = "n/a")
        {

        }

        public void LogDebugEvent(Exception ex, string functionName = "n/a")
        {

        }

        public void LogDebugEvent(string message, string functionName = "n/a")
        {

        }

        public void LogErrorEvent(Exception ex, string functionName = "n/a")
        {

        }

        public void LogErrorEvent(string message, string functionName = "n/a")
        {

        }
    }
}