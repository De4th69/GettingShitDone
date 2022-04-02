namespace GettingShitDone.Database.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}
