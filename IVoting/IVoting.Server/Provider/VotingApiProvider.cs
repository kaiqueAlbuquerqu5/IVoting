using IVoting.Server.Models.Register;
using IVoting.Server.Provider.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace IVoting.Server.Provider
{
    public class VotingApiProvider : IvotingApiProviderInterface
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public VotingApiProvider(HttpClient httpClient, IOptions<VotingApiOptions> options)
        {
            _httpClient = httpClient;
            _baseUrl = options.Value.BaseUrl;
        }

        public async Task<EmptyResult> RegisterHostAsync(RegisterRequest request, CancellationToken cancellationToken)
        {
            var uri = $"{_baseUrl}/host/register";

            var response = await _httpClient.PostAsJsonAsync(uri, request, cancellationToken);

            response.EnsureSuccessStatusCode();

            return new EmptyResult();
        }
    }
}
