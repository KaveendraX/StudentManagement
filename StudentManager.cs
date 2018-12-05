using H2C.Student.Common.Lib.Log.Contracts;
using H2C.Student.Common.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2C.Student.BusinessServices
{
    public sealed class StudentManager : BaseManager
    {
        public StudentManager(IAppSettings appSettings,ILogger logger) : base(appSettings,logger)
        {

        }


    }
}
