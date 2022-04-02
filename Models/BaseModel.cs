using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GettingShitDone.Models
{
    [Serializable]
    public class BaseModel : INotifyPropertyChanged
    {
        private DateTime? _insertDate;

        private DateTime? _updateDate;

        private DateTime? _deleteDate;

        public DateTime? InsertDate
        {
            get => this._insertDate;
            set
            {
                this._insertDate = value;
                OnPropertyChanged();
            }
        }

        public DateTime? UpdateDate
        {
            get => this._updateDate;
            set
            {
                this._updateDate = value;
                OnPropertyChanged();
            }
        }

        public DateTime? DeleteDate
        {
            get => this._deleteDate;
            set
            {
                this._deleteDate = value;
                OnPropertyChanged();
            }
        }

        public bool IsDirty { get; set; }

        public bool IsNew { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            this.IsDirty = true;
        }
    }
}
