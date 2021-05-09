using OC.Application.ViewModels.Authentications;
namespace OC.Application.Results.Auth
{
    public class LoginResult : Result<LoginViewModel>
    {
        public LoginResult(LoginViewModel model) : base(model) { }
    }
}