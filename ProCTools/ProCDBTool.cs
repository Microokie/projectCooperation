using ProCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCTools
{
    public class ProCDBTool
    {
        public static List<TUser> GetUsers()
        {
            using (LQ2DBDataContext db = new LQ2DBDataContext())
            {
                return (from tc in db.TUser select tc).ToList();
            }
        }
    }
}
