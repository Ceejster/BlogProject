namespace BlogProject.ViewModels
{
    public class EmailSettings
    {
        //can configure and use an SMTP server
        public string? Email { get; set; }
        public string? DisplayName { get; set; }
        public string? Password { get; set; }
        public string? Host { get; set; }
        public int Port { get; set; }
    }
}
