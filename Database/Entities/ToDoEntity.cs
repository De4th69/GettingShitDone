namespace GettingShitDone.Database.Entities
{
    public partial class ToDoEntity : BaseEntity
    {
        public Guid? ToDiId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid? CategoryId { get; set; }

        public CategoryEntity Category { get; set; }

        public Guid? ReminderId { get; set; }

        public ReminderEntity Reminder { get; set; }

        public DateTime? DoneDate { get; set; }

        public bool? IsDaily { get; set; }

        public bool? IsWeekly { get; set; }

        public bool? IsMonthly { get; set; }

        public bool? IsQuarterly { get; set; }

        public bool? IsHalfYear { get; set; }
        
        public bool? IsYearly { get; set; }

        public bool? IsCustom { get; set; }
    }
}
