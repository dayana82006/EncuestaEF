using ApiP.DTOs.Auth;
namespace Application.Services;

public interface IUserService
{
    //tendremos manejo de usuarios, roles, autenticación y autorización
    Task<string> RegiusterAsync(RegisterDto model);
    Task<DataUserDto> GetTokenAsync(LoginDto model);
    Task<string> AddRolAsync(AddRolDto model);
    
    Task<DataUserDto> RefreshTokenAsync(string refreshToken);

}
