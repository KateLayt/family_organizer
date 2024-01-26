using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.DateTime;

namespace FamilyOrganizer
{
    internal class Person
    {
        private string _name;
        private DateTime _birthDate;

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            _birthDate = birthDate;
        }



        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Имя должно содержать символы.");
                _name = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                if (value > DateTime.Today) throw new ArgumentOutOfRangeException("Дата рождения не может быть позднее сегодня.");
                _birthDate = value;
            }

        }
    }
}
