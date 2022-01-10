using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace DAL
{
    public class PrivateInstallationDb : IPrivateInstallationDb
    {
        //public IConfiguration Configuration => throw new NotImplementedException();
        public IConfiguration Configuration { get; }

        public PrivateInstallationDb(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public PrivateInstallationDb()
        {

        }

        public bool postMyInfo(List<Object> dataList)
        {

            File.WriteAllText("../NEE/Properties/data.json", JsonConvert.SerializeObject(dataList, Formatting.Indented));

            return true;
        }
    }
}
