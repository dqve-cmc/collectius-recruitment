using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Recruitment.API.Services
{
    public class Md5Service: IMd5Service
    {
        private readonly IConfiguration _configuration;
        public Md5Service(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public string Encode(string data)
        {
            var prefix = _configuration.GetValue<string>("AuthenticationPrefix");
            var suffix = DateTime.UtcNow.ToString("dd MMMM yyyy");
            var md5Provider = new MD5CryptoServiceProvider();
            var hashValue = md5Provider.ComputeHash(new UTF8Encoding().GetBytes(prefix + data + suffix));
            var sb = new StringBuilder();
            foreach (var b in hashValue)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
