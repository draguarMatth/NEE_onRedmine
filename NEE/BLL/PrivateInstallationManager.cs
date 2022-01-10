using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PrivateInstallationManager : IPrivateInstallationManager
    {


        //public IPrivateInstallationDb PrivateInstallationDb => throw new NotImplementedException();
        public IPrivateInstallationDb PrivateInstallationDb { get; }


        public PrivateInstallation postMyInfo()
        {
            //throw new NotImplementedException();
            return PrivateInstallationDb.postMyInfo();
        }
    }
}
