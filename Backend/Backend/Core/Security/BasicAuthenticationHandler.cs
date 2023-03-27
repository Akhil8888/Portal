using Backend.Core.RepositoryInterface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace Backend.Core.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IUserRepository _userRepository;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, IUserRepository userRepository,
           UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
            _userRepository = userRepository;
        }
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string username = string.Empty;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                String[] credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeader.Parameter ??
                    string.Empty)).Split(':');
                if (credentials.Length == 0)
                    throw new ArgumentException("Invalid Credentials");

                username = credentials.FirstOrDefault() ?? string.Empty;
                String password = credentials.LastOrDefault() ?? string.Empty;

                if (!_userRepository.CheckValidUser(username, password))
                    throw new ArgumentException("Invalid Credentials");

                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, username)
                };
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);
                return AuthenticateResult.Success(ticket);
            }

            catch (Exception ex)
            {
                return AuthenticateResult.Fail($"Authentication Failed{ex.Message}");
            }



        }
    }
}
