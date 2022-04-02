namespace GettingShitDone.Models
{
    [Serializable]
    public class ToDoModel : BaseModel
    {
        private string _title;

        private string _description;

        private Guid? _categoryId;

        private Guid? _reminderId;

        private DateTime? _doneDate;

        private bool? _isDaily;

        private bool? _isWeekly;

        private bool? _isMonthly;

        private bool? _isQuarterly;

        private bool? _isHalfYear;

        private bool? _isYearly;

        private bool? _isCustom;

        public Guid? ToDoId { get; set; }

        public string Title
        {
            get => this._title;
            set
            {
                this._title = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => this._description;
            set
            {
                this._description = value;
                OnPropertyChanged();
            }
        }

        public Guid? CategoryId
        {
            get => this._categoryId;
            set
            {
                this._categoryId = value;
                OnPropertyChanged();
            }
        }

        public string CategoryName { get; set; }

        public string CategoryColor { get; set; }

        public Guid? ReminderId
        {
            get => this._reminderId;
            set
            {
                this._reminderId = value;
                OnPropertyChanged();
            }
        }

        public string ReminderIntervalName { get; set; }

        public string ReminderValue { get; set; }

        public DateTime? DoneDate
        {
            get => this._doneDate;
            set
            {
                this._doneDate = value;
                OnPropertyChanged();
            }
        }

        public bool? IsDaily
        {
            get => this._isDaily;
            set
            {
                this._isDaily = value;
                OnPropertyChanged();
            }
        }

        public bool? IsWeekly
        {
            get => this._isWeekly;
            set
            {
                this._isWeekly = value;
                OnPropertyChanged();
            }
        }

        public bool? IsMonthly
        {
            get => this._isMonthly;
            set
            {
                this._isMonthly = value;
                OnPropertyChanged();
            }
        }

        public bool? IsQuarterly
        {
            get => this._isQuarterly;
            set
            {
                this._isQuarterly = value;
                OnPropertyChanged();
            }
        }

        public bool? IsHalfYear
        {
            get => this._isHalfYear;
            set
            {
                this._isHalfYear = value;
                OnPropertyChanged();
            }
        }


        public bool? IsYearly
        {
            get => this._isYearly;
            set
            {
                this._isYearly = value;
                OnPropertyChanged();
            }
        }

        public bool? IsCustom
        {
            get => this._isCustom;
            set
            {
                this._isCustom = value;
                OnPropertyChanged();
            }
        }
    }
}
