namespace GettingShitDone.Models
{
    [Serializable]
    public class ReminderModel : BaseModel
    {
        private Guid? _reminderIntervalTypeId;

        private int? _reminderIntervalValue;

        public Guid? ReminderId { get; set; }

        public Guid? ReminderIntervalTypeId
        {
            get => this._reminderIntervalTypeId;
            set
            {
                this._reminderIntervalTypeId = value;
                OnPropertyChanged();
            }
        }

        public int? ReminderIntervalValue
        {
            get => this._reminderIntervalValue;
            set
            {
                this._reminderIntervalValue = value;
                OnPropertyChanged();
            }
        }

        public string ReminderIntervalName { get; set; }
    }
}
