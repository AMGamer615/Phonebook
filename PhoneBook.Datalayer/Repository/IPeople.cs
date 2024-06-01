using PhoneBook.Datalayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Datalayer.Repository
{
    public interface IPeople
    {
        bool Insert(PeopleViewModel entity);
        List<PeopleViewModel> GetAll();
        List<PeopleViewModel> Search(string parameter);
        void Delete(int Id);
    }
}
