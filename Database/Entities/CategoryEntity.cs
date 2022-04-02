namespace GettingShitDone.Database.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public Guid? CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Color { get; set; }

        public bool IsDefault { get; set; }
    }
}
