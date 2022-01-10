using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public interface IPrivateInstallationDb
    {
        IConfiguration Configuration { get; }

        PrivateInstallation postMyInfo();
    }
}
