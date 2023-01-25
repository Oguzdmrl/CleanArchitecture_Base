using CleanArchitecture.Domain.Base;

namespace CleanArchitecture.Domain.Entities
{
    public sealed class Product : BaseEntity
    {
        public string Name { get; set; }
    }
}