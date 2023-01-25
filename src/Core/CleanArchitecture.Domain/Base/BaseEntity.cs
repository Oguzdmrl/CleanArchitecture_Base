namespace CleanArchitecture.Domain.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Created_Date { get; set; } = DateTime.Now;
        public DateTime Updated_Date { get; set; }
    }
}