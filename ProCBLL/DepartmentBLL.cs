using ProCDAL;
using ProCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCBLL
{
    public class DepartmentBLL
    {
        public static void Add(TDepartment department)
        {
            DepartmentDAL.Add(department);
        }
    }
}
