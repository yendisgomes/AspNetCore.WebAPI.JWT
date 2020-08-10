namespace AspNetCore.WebAPI.JWT.Repositories
{
    public static class UserRepository
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }   
}
