using MindVault.Models.Models.Commands;

namespace MindVault.ApplicationLayer.CQRS.Commands.Handlers
{
    /// <summary>
    /// Handles the execution of a save password command.
    /// </summary>
    /// <remarks>This method processes the provided <see cref="LoginCommand"/> to handle user login
    /// operations.  Ensure that the <paramref name="command"/> contains valid login credentials before invoking this
    /// method.</remarks>
    public class LoginCommandHandler
    {
        public void Handle(LoginCommand command)
        {
            // TODO: Implement login handling (e.g. save login/password)
        }
    }
}
