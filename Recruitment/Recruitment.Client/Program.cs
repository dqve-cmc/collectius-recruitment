using CommandQuery.Client;
using Recruitment.Contracts.Commands;
using System;
using System.Threading.Tasks;

namespace Recruitment.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var commandClient = new CommandClient("https://localhost:5003/api/command/CalculateHashCommand");
            var result = await commandClient.PostAsync(new CalculateHashCommand { Login = "admin", Password= "admin" });
            Console.WriteLine(result);
        }
    }
}
