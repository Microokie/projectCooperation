using ProCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCDAL
{
    public class loginDAL
    {
        public static void Add()
        {
            //t_bas_user tu = new t_bas_user {logname="yansen",password="yansen123",phone="18501230123",deptno="cqp00101"};

            Console.WriteLine("---------------begin add a class");
            using (LQ2DBDataContext db = new LQ2DBDataContext())
            {
                TUser tu = new TUser { logname = "yansen", name="颜森",password = "yansen123", phone = "18501230123"};

                //db.Log = Console.Out; //for output sql statement
                db.TUser.InsertOnSubmit(tu);
                db.SubmitChanges();
            }
            Console.WriteLine("--------------end");
        } 

        public static List<TUser> SimpleQuery()
        {
            using (LQ2DBDataContext db = new LQ2DBDataContext())
            {
                var query = from tc in db.TUser
                            select tc;
                //select new
                //{
                //    logname = tc.logname,
                //    phone = tc.phone
                //};
                //Console.WriteLine("output results for table of class");
                //int i = 1;
                //foreach (var item in query)
                //{
                //    Console.WriteLine("{0},logname:{1},phone:{2}", i, item.logname, item.phone);
                //    i++;
                //}
                //List<TUser> userList = query.ToList<TUser>();
                return query.ToList<TUser>();
            }
        }

        public static TUser FindByLogname(string userLogname)
        {
            using (LQ2DBDataContext db = new LQ2DBDataContext())
            {
                var query = from tc in db.TUser
                            where tc.logname == userLogname
                            select tc;
                if(query.Count() > 0)
                {
                    return query.First();
                }
                return null;
            }
        }
    }
}
