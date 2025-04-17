using System.Reflection.PortableExecutable;
using Application.Interfaces;
using Application.Models.Register;
using Application.Validators;
using Domain.Entities;
using FluentValidation;

namespace Application.Handlers.Register
{
    public class RegisterHostHandler
    {
        private readonly IHostRepository _repository;

        public RegisterHostHandler(IHostRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> HandleAsync(RegisterHostRequest request)
        {
            var validator = new RegisterHostValidator();
            var validationResult = validator.Validate(request);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var newHost = AdaptObject(request);
            return await _repository.AddHostAsync(newHost);
        }

        public static Host AdaptObject(RegisterHostRequest request)
        {
            return new Host
            {
                HostName = request.Name,
                HostEmail = request.Email,
                CreatedBy = Environment.MachineName
            };
        }
    }
}
