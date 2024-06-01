using PhoneBook.Datalayer.Model;
using PhoneBook.Datalayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Datalayer.Services
{
    public class RoleService : IRole
    {
        public Dictionary<int, string> GetRoles()
        {
            MyDbContext DB = new MyDbContext();
            Dictionary<int,string> Roles = new Dictionary<int,string>();
            var Dic = DB.Roles.Select(x => x);
            foreach (var d in Dic)
            {
                Roles.Add(d.RoleId, d.RoleTitle);
            }
            return Roles;
        }
    }
}
