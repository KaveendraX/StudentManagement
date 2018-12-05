using H2C.Student.Common.Lib.Log.Contracts;
using H2C.Student.Common.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2C.Student.BusinessServices
{
    public abstract class BaseManager
    {
        protected ILogger _logger;
        protected IAppSettings _appSettings;
        

        public BaseManager(IAppSettings appSettings, ILogger logger)
        {
            this._logger = logger;
            this._appSettings = appSettings;
        }

    }
}
