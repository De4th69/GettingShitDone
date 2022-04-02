namespace GettingShitDone.Database.Entities
{
    public class ReminderIntervalTypeEntity : BaseEntity
    {
        public Guid? ReminderIntervalTypeId { get; set; }

        public string ReminderIntervalTypeName { get; set; }
    }
}
