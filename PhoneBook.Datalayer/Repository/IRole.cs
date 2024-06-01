using PhoneBook.Datalayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Datalayer.Repository
{
    public interface IRole
    {
        public Dictionary<int, string> GetRoles();
    }
}
