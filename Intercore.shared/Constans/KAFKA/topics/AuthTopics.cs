namespace Intercore.shared.Constans.KAFKA.topics;

public static class AuthTopics
{

    //comando cmd es una orden accion
    public const string LoginRequest = "auth.cmd.login-request";
//evento que ya paso como aviso
    public const string UserLoggedIn = "auth.evt.user-logged-in";
    public const string UserLoginFailer = "auth.evt.user-login-failed";
    
    
    
    
    
    /// <summary>
    ///Estudiar 
    /// </summary>
    public const string RegisterUserCommand = "auth.cmd.register-user";
    
    
    public const string UserRegisteredEvent = "auth.evt.user-registered";


    //recordar mantener formato de acciones (presente /  pasado)
    //orden
    public const string RecoverPasswordCommand = "auth.cmd.recovery-password";
    //evento en cuestion 
    public const string PasswordRecoveryRequested = "auth.evt.recovery-password-event";
    
    



}