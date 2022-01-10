using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public interface IPrivateInstallationDb
    {
        IConfiguration Configuration { get; }

        bool postMyInfo(List<Object> dataList);
    }
}
