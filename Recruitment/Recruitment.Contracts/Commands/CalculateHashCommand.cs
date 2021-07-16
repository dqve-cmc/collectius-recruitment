using CommandQuery;

namespace Recruitment.Contracts.Commands
{
    public class CalculateHashCommand : ICommand<string>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
