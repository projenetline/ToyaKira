namespace Rent.Domain.Concrete
{
    public class LogoDbSetting
    {
        public string LogoDBDataSource { get; set; }
        public string LogoDBInitialCatalog { get; set; }
        public string LogoDBPass { get; set; }
        public string LogoDBUser { get; set; }
        public string LogoAppPassword { get; set; }
        public string LogoAppUserID { get; set; }
        public string LogoAppFirmNr { get; set; }
        public string LogoAppPerNr { get; set; }
        public int LogoAppRepeatTime { get; set; } = 30;
    }
}
