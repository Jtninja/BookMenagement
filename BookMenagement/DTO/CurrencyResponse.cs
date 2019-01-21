namespace BookMenagement.Api.DTO
{
    public class CurrencyResponse {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public char Symbol { get; set; }
        public bool IsDefault { get; set; }
        public decimal DefaultRatio { get; set; }
    }
}
