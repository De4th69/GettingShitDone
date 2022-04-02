namespace GettingShitDone.Database.Entities
{
    public partial class ReminderEntity
    {
        public string ReminderIntervalName
        {
            get
            {
                if(this.ReminderType != null)
                {
                    return this.ReminderType.ReminderIntervalTypeName;
                }

                return string.Empty;
            }
        }
    }
}
