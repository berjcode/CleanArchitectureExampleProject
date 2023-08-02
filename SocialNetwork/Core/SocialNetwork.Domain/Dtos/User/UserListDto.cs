namespace SocialNetwork.Domain.Dtos.User;

public class UserListDto :BaseDto
{
    public string UserName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
}
