namespace OutsideInDevelopment
{
    internal class RunDetails
    {
        public string[] GroupsToPost { get; set; }
        public string path { get; set; }
        public LoginDetails loginDetails { get; set; }
        public RunDetails(string[] GroupsToPost, string path, LoginDetails loginDetails)
        {
            this.GroupsToPost = GroupsToPost;
            this.path = path;
            this.loginDetails = loginDetails;
        }
        public string Email()
        {
            return loginDetails.email;
        }
        public string Password()
        {
            return loginDetails.password;
        }
    }
}