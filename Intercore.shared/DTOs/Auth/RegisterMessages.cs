namespace Intercore.shared.DTOs.Auth;

public class RegisterMessages
{



    public record RegisterRequest(string FullName, string Email, string Password);
    
    
    public record RegisterResponse(bool IsSuccess, Guid? UserId, string? ErrorMessage);

 
    
}