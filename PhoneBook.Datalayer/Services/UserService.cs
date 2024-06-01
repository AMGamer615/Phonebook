using PhoneBook.Datalayer.DTOs;
using PhoneBook.Datalayer.Entities.User;
using PhoneBook.Datalayer.Model;
using PhoneBook.Datalayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Datalayer.Services
{
    public class UserService : IUser
    {
        public bool Authorization(string UserName)
        {
            throw new NotImplementedException();
        }

        public bool ChangedPass(string UserName, string Oldpassword, string Newpassword)
        {
            throw new NotImplementedException();
        }

        public UserViewModel SelectUserByPassword(string UserName, string password)
        {
            MyDbContext DB = new MyDbContext();
            UserViewModel userViewModel = new UserViewModel();
            User user = DB.Users.FirstOrDefault(x => x.UserName == UserName && x.Password == password);
            if (user != null)
            {
                userViewModel.UserName = user.UserName;
                userViewModel.FullFamily = user.FullFamily;
                userViewModel.RoleId = user.RoleId;

                return userViewModel;
            }
            return null;
        }
    }
}
