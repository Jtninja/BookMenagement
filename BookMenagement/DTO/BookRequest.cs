namespace BookMenagement.Api.DTO
{
    public class BookRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Amount { get; set; }
        public int CurrencyId { get; set; }
        public int BookCategoryId { get; set; }
        public int  AuthorId { get; set; }
    }

}
