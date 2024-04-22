namespace JWTProject.Service
{
    public interface IJWTService
    {
        string GetJWT(string user, string role);
    }
}