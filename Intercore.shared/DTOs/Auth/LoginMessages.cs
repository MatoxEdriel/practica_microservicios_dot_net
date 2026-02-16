namespace Intercore.shared.DTOs.Auth;

public class LoginMessages
{

    public record LoginRequest(string Email, string Password);

    public record LoginResponse(bool IsSuccess, string? Token, string? ErrorMessage);


}