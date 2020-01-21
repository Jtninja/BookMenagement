using BookMenagement.DAL.Model;
using BookMenagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMenagement.BLL.Parser
{
    public static partial class Parser
    {
        public static AuthorModel Parse(Author author, int authorId)
        {
            var model = new AuthorModel();

            if (author != null)
            {

                model.ArtistName = author.ArtistName;
                model.Person = Parse(author.Person, author.PersonId);
                model.PersonId = author.PersonId;

            }
            model.Id = authorId;
            return model;
        }
        public static AuthorModel Parse(Author sc)
        {
            if (sc == null)
            {
                return null;
            }
            var author = new AuthorModel();

            author.Id = sc.Id;
            author.ArtistName = sc.ArtistName;
            author.PersonId = sc.PersonId;
            author.Person = Parse(sc.Person);

            return author;
        }
        public static Author Parse(AuthorModel sc)
        {
            return new Author
            {
                ArtistName = sc.ArtistName,
                PersonId = sc.PersonId

            };
        }

    }
}

