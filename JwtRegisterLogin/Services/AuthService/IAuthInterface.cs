using JwtRegisterLogin.Dtos;
using JwtRegisterLogin.Models;

namespace JwtRegisterLogin.Services.AuthService
{
    public interface IAuthInterface
    {
        Task<Response<UsuarioCriacaoDto>> Registrar(UsuarioCriacaoDto usuarioRegistro);
        Task<Response<string>> Login(UsuarioLoginDto usuarioLogin);
    }
}
