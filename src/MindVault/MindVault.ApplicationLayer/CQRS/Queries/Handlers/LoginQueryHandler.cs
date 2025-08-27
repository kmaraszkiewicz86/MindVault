using FluentResults;
using MindVault.Models.Cqrs.Queries;
using SimpleCqrs;

namespace MindVault.ApplicationLayer.CQRS.Queries.Handlers
{
    /// <summary>
    /// Handles the processing of verifying user credentials.
    /// </summary>
    /// <remarks>This class is responsible for managing the execution of login queries.  It processes
    /// the provided <see cref="LoginQuery"/> to perform operations such as  validating user credentials or initiating
    /// authentication workflows.</remarks>
    public class LoginQueryHandler : IAsyncQueryHandler<LoginQuery, Result>
    {
        public Task<Result> HandleAsync(LoginQuery query, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(Result.Fail("fail"));
        }
    }
}
