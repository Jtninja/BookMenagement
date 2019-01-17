using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMenagement.BLL
{
    public class AuthorService : IAuthorService
    {
        #region fields and ctr
        private readonly IRepository<Author> _authorRepository;
        private readonly IPersonService personService;
        public AuthorService(IRepository<Author> repository, IPersonService personService)
        {
            _authorRepository = repository;

            this.personService = personService;
        }
        #endregion

        #region CRUD
        public void Create(AuthorModel sc)
        {
            if (sc == null|| sc.Person == null)
                
            {
                throw new ArgumentNullException();
            }
            if (sc.Id != 0)
            {
                throw new ArgumentNullException("Id cant be !=0 ");
            }
            HandlePerson(sc);
            Author model = Parse(sc);

            _authorRepository.Insert(model);
            _authorRepository.Save();
        }
        public void Delete(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("Id cant be 0 ");
            }
            _authorRepository.Delete(id);
            _authorRepository.Save();
        }      
        public void Update(AuthorModel sc)
        {
            if (sc == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Person == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id==0)
            {
                throw new ArgumentNullException();
            }
            HandlePerson(sc);

            var model = Parse(sc);
            model.Id = sc.Id;

            _authorRepository.Update(model);
            _authorRepository.Save();
        }
        public List<AuthorModel> GetAll()
        {
            return _authorRepository.GetAll()
                             .Select(a => Parse(a))
                             .ToList();
        }
        public AuthorModel GetById(int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("Id cant be 0 ");
            }
            var model = _authorRepository.GetById(id);
            if (model != null)
            {
                return Parse(model);
            }
            return null;
        }
        #endregion
        
        #region Helpers
        private Author Parse(AuthorModel sc)
        {
            return new Author
            {
                ArtistName = sc.ArtistName,
                PersonId = sc.PersonId
            };
        }
        private void HandlePerson(AuthorModel sc)
        {
            if (sc.PersonId == 0)
            {

                if (!personService.Any(sc.Person.Name, sc.Person.Surname))
                {
                    personService.Create(sc.Person);
                }
                sc.Person = personService.FirstOrDefaultByData(sc.Person.Name ,sc.Person.Surname);
                sc.PersonId = sc.Person.Id;
            }
            else
            {
                if (!personService.Any(sc.PersonId))
                {
                    throw new ArgumentException("Person info provided couldnt be loaded");
                }
            }
        }
        private AuthorModel Parse(Author sc)
        {
            var author = new AuthorModel() { Person = new PersonModel() };
            if (sc != null)
            {
                author.Id = sc.Id;
                author.ArtistName = sc.ArtistName;
                author.PersonId = sc.PersonId;
                author.Person.Id = sc?.Person?.Id ?? 0;
                author.Person.Name = sc?.Person?.Name;
                author.Person.Surname = sc?.Person?.Surname;


            }
            return author;
        }
        #endregion

    }
}
