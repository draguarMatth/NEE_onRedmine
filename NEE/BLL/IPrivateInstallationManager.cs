using System;
using System.Collections.Generic;
using DAL;


namespace BLL
{
    public interface IPrivateInstallationManager
    {
        IPrivateInstallationDb PrivateInstallationDb {get;}

        bool postMyInfo(List<Object> dataList);
    }
}
