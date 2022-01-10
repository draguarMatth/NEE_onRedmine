using DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class PrivateInstallationManager : IPrivateInstallationManager
    {

        public PrivateInstallationManager()
        {

        }

        public PrivateInstallationManager(IPrivateInstallationDb privateInstallationDb)
        {
            PrivateInstallationDb = privateInstallationDb;
        }

        //public IPrivateInstallationDb PrivateInstallationDb => throw new NotImplementedException();
        public IPrivateInstallationDb PrivateInstallationDb { get; }


        public bool postMyInfo(List<Object> dataList)
        {

            PrivateInstallationDb pidb = new PrivateInstallationDb();

            return pidb.postMyInfo(dataList);
        }
    }
}
