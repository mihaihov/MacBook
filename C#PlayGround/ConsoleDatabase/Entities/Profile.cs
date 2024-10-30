namespace ConsoleDatabase.Entities
{
    public class Profile
    {
        public int ProfileId {get;set;}
        public int UserId {get;set;}
        public string FirstName {get;set;} = string.Empty;
        public string LastName {get;set;} = string.Empty;
    }
}