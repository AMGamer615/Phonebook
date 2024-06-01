using PhoneBook.Datalayer.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Datalayer.Repository
{
    public interface IUser
    {
        UserViewModel SelectUserByPassword (string UserName,string password);

        bool ChangedPass(string UserName, string Oldpassword, string Newpassword);

        bool Authorization(string UserName);

       
    }
}
