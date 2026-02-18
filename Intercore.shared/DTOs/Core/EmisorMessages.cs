namespace Intercore.shared.DTOs.Core;

public class EmisorMessages
{
    
    public record EmisorRequest(string Email, string Password);

    public record EmisorResponse(bool IsSuccess, string? Token, string? ErrorMessage);
    
}