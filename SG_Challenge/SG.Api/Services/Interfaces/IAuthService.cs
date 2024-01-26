namespace SG.Api.Services.Interfaces
{
    public interface IAuthService
    {

        string GenerateToken(string userId);

    }
}
