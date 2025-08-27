using FluentResults;
using MindVault.Models.Cqrs.Commands;
using SimpleCqrs;

namespace MindVault.ApplicationLayer.CQRS.Commands.Handlers
{
    /// <summary>
    /// Handles the execution of a save password command.
    /// </summary>
    /// <remarks>This method processes the provided <see cref="LoginCommand"/> to handle user login
    /// operations.  Ensure that the <paramref name="command"/> contains valid login credentials before invoking this
    /// method.</remarks>
    public class LoginCommandHandler : IAsyncCommandHandler<LoginCommand, Result>
    {
        public Task<Result> HandleAsync(LoginCommand command, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(Result.Fail("fail"));
        }
    }
}
