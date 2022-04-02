namespace GettingShitDone.Database.Entities
{
    public partial class ToDoEntity
    {
        public string CategoryName
        {
            get
            {
                if(this.Category != null)
                {
                    return this.Category.Name;
                }

                return string.Empty;
            }
        }

        public string CategoryColor
        {
            get
            {
                if(this.Category != null)
                {
                    return this.Category.Color;
                }

                return string.Empty;
            }
        }

        public string ReminderIntervalName
        {
            get
            {
                if(this.Reminder != null)
                {
                    return this.Reminder.ReminderIntervalName;
                }

                return string.Empty;
            }
        }

        public int? ReminderValue
        {
            get
            {
                if(this.Reminder != null)
                {
                    return this.Reminder.ReminderValue;
                }

                return 0;
            }
        }
    }
}
