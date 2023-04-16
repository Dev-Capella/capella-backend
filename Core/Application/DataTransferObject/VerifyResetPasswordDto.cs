namespace Application.DataTransferObject;

public class VerifyResetPasswordDto
{
    public string ResetPasswordToken { get; set; }
    public string UserId { get; set; }
}