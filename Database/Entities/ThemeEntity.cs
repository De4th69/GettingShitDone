namespace GettingShitDone.Database.Entities
{
    public class ThemeEntity : BaseEntity
    {
        public Guid? ThemeId { get; set; }

        public string TextPrimaryColor { get; set; }

        public string TextSecondaryColor { get; set; }

        public string BackgroundColor { get; set; }

        public string ForegroundColor { get; set; }
    }
}
