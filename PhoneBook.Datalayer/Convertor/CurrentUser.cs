using PhoneBook.Datalayer.Model;
using PhoneBook.Datalayer.Repository;
using PhoneBook.Datalayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Datalayer.Convertor
{
    public static class CurrentUser
    {
        public static string UserName { get; set; }
        public static string FullFamily { get; set; }
        public static bool IsAdmin { get; set;} = false;
    }
}
