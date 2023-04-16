namespace Application.DataTransferObject;

public class UpdatePasswordDto
{
    public string UserId { get; set; }
    public string ResetPasswordToken { get; set; }
    public string Password { get; set; }
    public string PasswordConfirm { get; set; }
}