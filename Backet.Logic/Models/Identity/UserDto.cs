namespace Backet.Logic.Models.Identity
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<RoleDto> Roles { get; set; }
        public List<PlayStatsDto> Stats { get; set; }
    }
}
