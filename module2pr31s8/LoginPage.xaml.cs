using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace module2pr31s8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            if (!Preferences.ContainsKey("Login"))
            {
                GoToRegistratonPage();
            }
        }

        private void Registration(object sender, EventArgs e)
        {
            if ((Preferences.Get("Login",0)==EntryLogin.Text.GetHashCode())&& 
                (Preferences.Get("Password", 0) == EntryPassword.Text.GetHashCode()))
            {
                Navigation.PopModalAsync();
            }else
            {
                DisplayAlert("Ошибка", "Логин или пароль введены неверно", "OK");
            }
        }
        private async void GoToRegistratonPage()
        {
            await Navigation.PushModalAsync(new RegistrationPage());
        }
    }
}