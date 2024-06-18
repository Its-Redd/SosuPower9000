using CommunityToolkit.Mvvm.Input;
using SosuPower.Maui.Views;
using SosuPower.Services;
using Task = System.Threading.Tasks.Task;

namespace SosuPower.Maui.viewmodels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        private IUserService userService;
        //dependency injection of IUserService to set the userId
        public LoginPageViewModel(IUserService userService)
        {
            this.userService = userService;
        }


        [RelayCommand]
        async Task GoToMainAsync(string UserInput)
        {

            if (int.TryParse(UserInput, out int id))
            {
                if (id > 0)
                {
                    var e = userService.GetUserAsync(id);
                    userService.Employee = await e;
                    await Shell.Current.GoToAsync($"{nameof(MainPage)}");

                }
            }
            return;
        }


    }
}