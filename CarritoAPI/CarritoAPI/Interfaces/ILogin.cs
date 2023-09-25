using Azure;
using CarritoAPI.Models;

namespace CarritoAPI.Interfaces
{
    public interface ILogin
    {
        public Task<UsuarioModel> Login(string correo, string password);
    }
}
