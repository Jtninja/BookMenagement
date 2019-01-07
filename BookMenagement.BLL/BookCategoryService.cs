using BookMenagement.Bll.Interfaces;
using BookMenagement.DAL.Interfaces;
using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookMenagement.BLL
{
    public class BookCategoryService : IBookCategoryService
    {

        public readonly IRepository<BookCategory> _repository;
        public BookCategoryService(IRepository<BookCategory> repository)
        {
            _repository = repository;
        }


        public void Create(BookCategoryModel sc)
        {
            if (sc==null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id!=0)
            {
                throw new ArgumentException("Id cant be provided in creation");
            }
            var model = new BookCategory { Code = sc.Code, Name = sc.Name };

            _repository.Insert(model);
            _repository.Save();
        }

        public void Delete(int id)
        {
            
            if (id == 0)
            {
                throw new ArgumentNullException();
            }

            _repository.Delete(id);
            _repository.Save();
        }

        public List<BookCategoryModel> GetAll()
        {
           return  _repository.GetAll()
                             .Select(a => 
                                new BookCategoryModel {
                                        Id = a.Id,
                                        Code = a.Code,
                                        Name = a.Name
                                }).ToList();
        }

        public BookCategoryModel GetById(int id)
        {
            var model = _repository.GetById(id);

            if (model!=null)
            {
                return new BookCategoryModel
                {
                    Id = model.Id,
                    Code = model.Code,
                    Name = model.Name
                };
            }
            return null;
        }

        public void Update(BookCategoryModel sc)
        {

            if (sc == null)
            {
                throw new ArgumentNullException();
            }
            if (sc.Id == 0)
            {
                throw new ArgumentNullException("Id cant be null");
            }

            var model = new BookCategory
            {
                Id = sc.Id,
                Code = sc.Code,
                Name = sc.Name
            };
            _repository.Update(model);
            _repository.Save();
        }
    }
}
