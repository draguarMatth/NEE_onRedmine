using DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public PrivateInstallation postMyInfo()
        {
            throw new NotImplementedException();
        }
    }
}
