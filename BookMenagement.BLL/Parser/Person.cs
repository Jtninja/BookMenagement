using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenagement.BLL.Parser
{
    public static partial class Parser
    {
        public static PersonModel Parse(Person person, int personId)
        {
            if (personId==0)
            {
                return Parse(person);
            }
            var model = new PersonModel();
            if (person != null)
            {
                model.Name = person.Name;
                model.PersonalNr = person.PersonalNr;
                model.Surname = person.Surname;
            }

            model.Id = person.Id;
            return model;
        }

        public static PersonModel Parse(Person person)
        {
            if (person==null)
            {
                return null;
            }
            return new PersonModel
            {
                Id = person.Id,
                Name = person.Name,
                PersonalNr = person.PersonalNr,
                Surname = person.Surname
            };
        }
    }
}
