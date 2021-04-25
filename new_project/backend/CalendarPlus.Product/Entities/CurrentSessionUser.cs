using CalendarPlus.Product.Contracts.Services;

namespace CalendarPlus.Product.Entities
{
    public class CurrentSessionUser : ICurrentSessionUser
    {
        public string Id { get; set; }
        public string GivenName { get; set; }
        public string SurName { get; set; }
        public string EmailAddress { get; set; }
    }
}
