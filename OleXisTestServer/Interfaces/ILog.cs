using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTestServer
{
    public interface ILog
    {
        void LogMessage(string message);
        void LogError(string message);
        void LogWarning(string message);
    }
}
