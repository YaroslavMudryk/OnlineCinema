using OC.Application.ViewModels.Users;
using System.Collections.Generic;
namespace OC.Application.Results.Users
{
    public class UserResult : Result<UserViewModel>
    {
        public UserResult(UserViewModel model) : base(model)
        {

        }
        public UserResult(string error) : base(error)
        {

        }
    }
    public class UserListResult : Result<List<UserViewModel>>
    {
        public UserListResult(List<UserViewModel> models) : base(models)
        {

        }
        public UserListResult(string error) : base(error)
        {

        }
    }
}