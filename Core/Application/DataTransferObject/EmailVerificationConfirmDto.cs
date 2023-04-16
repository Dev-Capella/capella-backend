namespace Application.DataTransferObject;

public class EmailVerificationConfirmDto
{
    public string EmailVerificationToken { get; set; }

    public string UserId { get; set; }
}