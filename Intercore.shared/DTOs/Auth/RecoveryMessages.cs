namespace Intercore.shared.DTOs.Auth;
//concepto al tratar record como data estatica significa que lo usaras para 
//transportart data y sacar y por eso se guarda el get y set por debajo
public class RecoveryMessages
{
    // envio Api a kafka 
    // Solo se pide correo del usuario, solicitud 
    public record RecoverPasswordRequest(string Email);
    
    //Evento que devuelve kafka cuando se termina xd 
    //estaria devolviendo el correo y el token o sea el response 
    public record PasswordRecoveryRequestedEvent(string Email, string RecoveryToken);
    
}