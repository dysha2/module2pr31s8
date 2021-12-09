using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.IO;

namespace module2pr31s8
{
    public partial class MainPage : ContentPage
    {
        string[] Systems;
        int[] SystemNumbers;
        public MainPage()
        {
            InitializeComponent();
            Systems = new string[] { "N2", "N8", "N10", "N16" };
            SystemNumbers = new int[] { 2, 8, 10, 16 };
            FirstSystem.ItemsSource = Systems;
            FirstSystem.SelectedItem = Systems[0];
            SecondSystem.ItemsSource = Systems;
            SecondSystem.SelectedItem = Systems[0];
            GoToLoginPage();
        }

        private async void GoToLoginPage()
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

        private void Operations(object sender, EventArgs e)
        {
            try
            {
                int FirstBase = SystemNumbers[FirstSystem.SelectedIndex];
                int SecondBase = SystemNumbers[SecondSystem.SelectedIndex];
                EntryAnswer.Text = Convert.ToString(Convert.ToInt32(Number.Text, FirstBase), SecondBase);
            } 
            catch (Exception ex) { DisplayAlert("Error", ex.Message, "OK"); }
           
        }
    }
}
