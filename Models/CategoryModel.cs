namespace GettingShitDone.Models
{
    [Serializable]
    public class CategoryModel : BaseModel
    {
        private string _name;

        private string _description;

        private string _color;

        public Guid? CategoryId { get; set; }

        public bool IsDefault { get; set; }

        public string Name
        {
            get => this._name;
            set
            {
                this._name = value;
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

        public string Color
        {
            get => this._color; 
            set
            {
                this._color = value;
                OnPropertyChanged();
            }
        }
    }
}
