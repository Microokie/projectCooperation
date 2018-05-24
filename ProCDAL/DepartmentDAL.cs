using ProCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCDAL
{
    public class DepartmentDAL
    {
        public static void Add(TDepartment department)
        {
            using (LQ2DBDataContext db = new LQ2DBDataContext())
            {
                db.TDepartment.InsertOnSubmit(department);
                db.SubmitChanges();
            }
        }
    }
}
