namespace GettingShitDone.Models
{
    [Serializable]
    public class SystemModel : BaseModel
    {
        private DateTime _notificationDate;

        private string _userName;

        private string _dbPassword;

        private int? _taskAmount;

        private Guid? _themeId;

        public string AppVersion { get; set; }

        public DateTime NotificationDate
        {
            get => this._notificationDate;
            set
            {
                this._notificationDate = value;
                OnPropertyChanged();
            }
        }

        public string UserName
        {
            get => this._userName;
            set
            {
                this._userName = value;
                OnPropertyChanged();
            }
        }

        public string DbPassword
        {
            get => this._dbPassword;
            set
            {
                this._dbPassword = value;
                OnPropertyChanged();
            }
        }

        public int? TaskAmount
        {
            get => this._taskAmount;
            set 
            {
                this._taskAmount = value;
                OnPropertyChanged();
            }
        }

        public Guid? ThemeId
        {
            get => this._themeId;
            set
            {
                this._themeId = value;
                OnPropertyChanged();
            }
        }
    }
}
