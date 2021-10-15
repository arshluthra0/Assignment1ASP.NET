namespace Project.Models
{
    public class LoggedInDetails
    {
        public string Id { get; set; }
        public string Name {  get; set; }       
        public string EmailId {  get; set; }
        public Models.Enums.LoginEnum Role { get; set; }
    }
}
