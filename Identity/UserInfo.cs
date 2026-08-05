namespace HyRest.Identity;

public record UserInfo
{
    public string? UserId { get; set; }
    public string? UserName { get; set; }
    public string? RealName { get; set; }
    public string? Email { get; set; }
}
