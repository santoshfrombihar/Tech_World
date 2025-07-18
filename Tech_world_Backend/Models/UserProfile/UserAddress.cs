namespace Tech_world_Backend.Models.UserProfile
{
    public class UserAddress
    {
        public int UserAddressId { get; set; }
        public string? FullAddress { get; set; }
        public string? CityName { get; set; }
        public string? PinCode { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
