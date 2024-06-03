using PhoneBook.Datalayer.Convertor;
using PhoneBook.Datalayer.DTOs;
using PhoneBook.Datalayer.Entities.User;
using PhoneBook.Datalayer.Model;
using PhoneBook.Datalayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Datalayer.Services
{
    public class UserService : IUser
    {
        public bool ChangedPass(string UserName, string Oldpassword, string Newpassword)
        {
            MyDbContext DB = new MyDbContext();
            User user = DB.Users.FirstOrDefault(x => x.UserName == UserName && x.Password == Oldpassword);
            if (user != null) 
            {
                try
                {
                    user.Password = Newpassword;
                    DB.Users.AddOrUpdate(user);
                    DB.SaveChanges();
                    return true;
                }
                catch 
                { 
                    return false;
                }
            }
            return false;
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

        public bool Insert(UserViewModel entity)
        {
            MyDbContext DB = new MyDbContext();

            User user = new User()
            {
                UserId = entity.UserId,
                UserName = entity.UserName,
                FullFamily = entity.FullFamily,
                Sex = entity.Sex,
                NationalID = entity.NationalID,
                PhoneNumber = entity.PhoneNumber,
                Email = entity.Email,
                Password = entity.Password,
                RoleId = entity.RoleId
            };
            try
            {
                user.BirthDay = Convert.ToDateTime(entity.BirthDay).ToMiladi();
                DB.Users.AddOrUpdate(user);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Authorization(string UserName)
        {
            MyDbContext DB = new MyDbContext();

            User user = DB.Users.FirstOrDefault(x => x.UserName == UserName);

            if (user == null)
            {
                return true;
            }
            return false;
        }
    }
}
