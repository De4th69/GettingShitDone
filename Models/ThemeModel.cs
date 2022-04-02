namespace GettingShitDone.Models
{
    [Serializable]
    public class ThemeModel : BaseModel
    {
        private string _textPrimaryColor;

        private string _textSecondaryColor;

        private string _backgroundColor;

        private string _foregroundColor;

        public Guid? ThemeId { get; set; }

        public string TextPrimaryColor
        {
            get => this._textPrimaryColor;
            set
            {
                this._textPrimaryColor = value;
                OnPropertyChanged();
            }
        }

        public string TextSecondaryColor
        {
            get => this._textSecondaryColor;
            set
            {
                this._textSecondaryColor = value;
                OnPropertyChanged();
            }
        }

        public string BackgroundColor
        {
            get => this._backgroundColor;
            set
            {
                this._backgroundColor = value;
                OnPropertyChanged();
            }
        }

        public string ForegroundColor
        {
            get => this._foregroundColor;
            set
            {
                this._foregroundColor = value;
                OnPropertyChanged();
            }
        }
    }
}
