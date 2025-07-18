namespace Tech_world_Backend.Models.UserProfile
{
    public class User
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddelName { get; set; }
        public string? LastName { get; set; }
        public string? PassWord { get; set; }
        public UserAddress? UserAddress { get; set; }
    }
}
