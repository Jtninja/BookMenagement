using BookMenagement.Api.DTO;
using BookMenagement.Model;


namespace BookMenagement.Api.Helpers
{
    public static partial class Parser
    {
       public static AuthorModel Parse(AuthorRequest source)
        {
            if (source == null)
                return null;

            var model = new AuthorModel
            {
                ArtistName = source.ArtistName,
                Id = source.Id,
                PersonId = source.PersonId,
                Person = ParsePerson(source)
            };
            return model;
        }

        private static PersonModel ParsePerson(AuthorRequest source)
        {
            if (source==null)
                return null;
            return new PersonModel
            {
                Id = source.PersonId,
                Name = source.PersonName,
                Surname = source.PersonSurname,
                PersonalNr=source.PersonPersonalNr
            };
        }

        public static AuthorResponse Parse(AuthorModel source)
        {
            if (source == null)
                return null;
            
            var model = new AuthorResponse
            {
                Id = source.Id,
                ArtistName = source.ArtistName,
                PersonId = source.PersonId,
                PersonName = source.Person?.Name,
                PersonSurname = source.Person?.Surname,
                PersonPersonalNr=source.Person?.PersonalNr
            };

            return model;
        }

    }
}
