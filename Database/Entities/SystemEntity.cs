namespace GettingShitDone.Database.Entities
{
    public class SystemEntity : BaseEntity
    {
        public string AppVersion { get; set; }

        public DateTime? NotificationTime { get; set; }

        public string UserName { get; set; }

        public Guid? ThemeId { get; set; }

        public string DbPassword { get; set; }

        public int TaskAmount { get; set; }
    }
}
