using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2C.Student.Common.Lib.Log.Contracts
{
    public interface ILogger
    {
        bool LogError(string errDescription, Exception err);

        bool LogInfo(string description);
    }
}
