using IVoting.Server.Models.Register;
using Microsoft.AspNetCore.Mvc;

namespace IVoting.Server.Provider.Interfaces
{
    public interface IvotingApiProviderInterface
    {
        Task<EmptyResult> RegisterHostAsync(RegisterRequest request, CancellationToken cancellationToken);
    }
}
