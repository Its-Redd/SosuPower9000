using CommunityToolkit.Mvvm.Input;
using SosuPower.Maui.Views;
using SosuPower.Services;
using Task = System.Threading.Tasks.Task;

namespace SosuPower.Maui.viewmodels
{
    public partial class LoginPageViewModel(IUserService userService) : BaseViewModel
    {
        [RelayCommand]
        protected async Task GoToMainAsync(string UserInput)
        {
            try { 
                if (CheckUserInput(UserInput))
                {
                    var e = await userService.GetUserAsync(Convert.ToInt32(UserInput));

                    await Shell.Current.GoToAsync(nameof(MainPage));
                    return;
                }

                throw new Exception("Indtast venligst et tal.");
            } catch(Exception e)
            {
                await Alert(e.Message);
                return;
            }
        }

        private static bool CheckUserInput(string UserInput)
        {
            // Hvis UserInput kan parses til en int, returner true
            if (int.TryParse(UserInput, out _))
            {
                return true;
            }

            // Ellers, returner false
            return false;
        }
    }
}