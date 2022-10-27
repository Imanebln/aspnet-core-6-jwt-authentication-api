using Data.Models;
using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace Services
{
    public interface IAuthService
    {
        public Task<AuthResponseModel> Login(LoginModel model);
        public Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user);
        public Task<AuthResponseModel> RegisterAsync(RegisterModel model);
    }
}
