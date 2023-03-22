using MediatR;

namespace User_UAuthentication.Command.AuthCommands
{
    public record ForgotPasswordCommand(string email):IRequest<string>
    {
    }
}
