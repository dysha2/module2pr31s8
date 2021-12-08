using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace module2pr31s8
{
    public partial class MainPage : ContentPage
    {
        string[] Systems;
        public MainPage()
        {
            InitializeComponent();
            if (File.Exists("file.txt"))
            {

            }
            else
            {
                GoToLoginPage();
            }
            File.Create("file.txt");
            Systems = new string[] { "N2", "N3", "N8", "N10", "N16" };
            FirstSystem.ItemsSource = Systems;
            FirstSystem.SelectedItem = Systems[0];
            SeconsSystem.ItemsSource = Systems;
            SeconsSystem.SelectedItem = Systems[0];
        }

        private async void GoToRegistrationPage()
        {
            await Navigation.PushModalAsync(new RegistrationPage());
        }

        private async void GoToLoginPage()
        {
            await Navigation.PushModalAsync(new LoginPage());
            GoToRegistrationPage();
        }

        private void Operations(object sender, EventArgs e)
        {
            switch (FirstSystem.SelectedItem)
            {
                case "N10":
                    int num = int.Parse(Number.Text);
                    TenToBinary(num);
                    break;
            }
        }
        private void TenToBinary(int num)
        {
           
        }
    }
}
