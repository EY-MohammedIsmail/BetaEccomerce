namespace User_UAuthentication.Models.DTO
{
    public class AuthResultsDto
    {
        public string accessToken { get; set; }
        public bool Result { get; set; }
        public List<string> Errors { get; set; }

        public string Role { get; set; }
    }
}
