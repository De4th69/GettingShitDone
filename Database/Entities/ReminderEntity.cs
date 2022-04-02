namespace GettingShitDone.Database.Entities
{
    public partial class ReminderEntity : BaseEntity
    {
        public Guid? ReminderId { get; set; }

        public Guid? ReminderIntervalTypeId { get; set; }

        public int? ReminderValue { get; set; }

        public ReminderIntervalTypeEntity ReminderType { get; set;}
    }
}
