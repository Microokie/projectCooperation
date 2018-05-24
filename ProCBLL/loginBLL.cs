using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProCDAL;
using ProCModel;

namespace ProCBLL
{
    public class loginBLL
    {
        public static Boolean login(string username,string password)
        {
            TUser loginuser = loginDAL.FindByLogname(username);
            if (loginuser != null && loginuser.password == password) return true;
            return false;
        }
    }
}
