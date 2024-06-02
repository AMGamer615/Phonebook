using PhoneBook.Datalayer.Convertor;
using PhoneBook.Datalayer.DTOs;
using PhoneBook.Datalayer.Entities.User;
using PhoneBook.Datalayer.Model;
using PhoneBook.Datalayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.Entity.Migrations;

namespace PhoneBook.Datalayer.Services
{
    public class PeopleService : IPeople
    {
        public void Delete(int Id)
        {
            MyDbContext DB = new MyDbContext();
            var people = DB.People.FirstOrDefault(x => x.PeopleId == Id);
            if (people != null)
            {
                DB.People.Remove(people);
                DB.SaveChanges();
            }
        }

        public List<PeopleViewModel> GetAll()
        {
            MyDbContext DB = new MyDbContext();
            List<PeopleViewModel> peopleVM = new List<PeopleViewModel>();

            var List = DB.People.Select(c => new PeopleViewModel()
            {
                PeopleId = c.PeopleId,
                Name = c.Name,
                LastName = c.LastName,
                Sex = c.Sex,
                Email = c.Email,
                PhoneNumber = c.PhoneNumber,
                BirthDay = c.BirthDay.ToString()
            }
            );
            foreach ( var item in List )
            {
                item.BirthDay = Convert.ToDateTime(item.BirthDay).ToShamsi();
                peopleVM.Add(item);
            }
            return peopleVM.ToList();
        }

        public bool Insert(PeopleViewModel entity)
        {
            MyDbContext DB = new MyDbContext();

            People people = new People()
            {
                PeopleId = entity.PeopleId,
                Name = entity.Name,
                LastName = entity.LastName,
                Sex = entity.Sex,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber
            };
            try
            {
                people.BirthDay = Convert.ToDateTime(entity.BirthDay).ToMiladi();
                DB.People.AddOrUpdate(people);
                DB.SaveChanges();
                return true;
            }
            catch ( Exception ex )
            {
                return false;
            }
        }

        public List<PeopleViewModel> Search(string parameter)
        {
            MyDbContext DB = new MyDbContext();
            List<PeopleViewModel> peopleVM = new List<PeopleViewModel>();

            var List =  DB.People.Where(x => x.Name.Contains(parameter) || x.LastName.Contains(parameter) || x.PhoneNumber.Contains(parameter)).Select(c => new PeopleViewModel
            {
                Name = c.Name,
                LastName = c.LastName,
                Sex = c.Sex,
                Email = c.Email,
                PhoneNumber = c.PhoneNumber,
                BirthDay = c.BirthDay.ToString()
            }
            );
            foreach (var item in List)
            {
                item.BirthDay = Convert.ToDateTime(item.BirthDay).ToShamsi();
                peopleVM.Add(item);
            }
            return peopleVM.ToList();
        }
    }
}
