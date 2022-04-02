namespace GettingShitDone.Models
{
    [Serializable]
    public class ReminderIntervalTypeModel : BaseModel
    {
        private string _reminderIntervalTypeName;

        public Guid? ReminderIntervalTypeId { get; set; }

        public string ReminderIntervalTypeName
        {
            get => this._reminderIntervalTypeName;
            set
            {
                this._reminderIntervalTypeName = value;
                OnPropertyChanged();
            }
        }
    }
}
