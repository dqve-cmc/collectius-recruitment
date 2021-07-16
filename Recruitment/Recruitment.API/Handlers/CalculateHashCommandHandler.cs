using CommandQuery;
using Recruitment.Contracts.Commands;
using System.Threading.Tasks;
using Recruitment.API.Services;

namespace Recruitment.API.Handlers
{
    public class CalculateHashCommandHandler : ICommandHandler<CalculateHashCommand, string>
    {
        private readonly IMd5Service _md5Service;

        public CalculateHashCommandHandler(IMd5Service md5Service)
        {
            _md5Service = md5Service;
        }

        public Task<string> HandleAsync(CalculateHashCommand command)
        {
            var result = _md5Service.Encode(command.Login + command.Password);

            return Task.FromResult(result);
        }
    }
}