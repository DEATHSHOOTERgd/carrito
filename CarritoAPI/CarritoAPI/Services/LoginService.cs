using CarritoAPI.Interfaces;
using CarritoAPI.Models;
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarritoAPI.Services
{
    public class LoginService : ILogin
    {
        private readonly EComerceDBContext _context;
        private readonly IConfiguration Configuration;

        public LoginService(EComerceDBContext context, IConfiguration configuration = null)
        {
            this._context = context;
            Configuration = configuration;
        }

        public async Task<UsuarioModel> Login(string email, string password)
        {
            var usuario = await _context.Usuarios.Where(u => u.Email.Equals(email)).FirstOrDefaultAsync();
            if (usuario == null)
            {
                throw new Exception("Usuario o contraseña incorrectos.");
            }

            if(BCrypt.Net.BCrypt.Verify(password, usuario.Password))
            {
                return new UsuarioModel
                {
                    Id = usuario.Id,
                    NombreUsuario=usuario.NombreUsuario,
                    Email=usuario.Email,
                    Token=GenerarJwtToken(usuario.Id)
                };
            }
            
            return null;
        }

        private string GenerarJwtToken(int userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTSecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userId.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = credentials
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
