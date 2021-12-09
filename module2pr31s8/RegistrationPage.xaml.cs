using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace module2pr31s8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Registration(object sender, EventArgs e)
        {
            string username = EntryUsername.Text;
            string password = EntryPassword.Text;
            Preferences.Set("SoldLog", RandomString(username.Length));
            Preferences.Set("SoldPass",RandomString(password.Length));
            SHA1 sHA1 = new SHA1CryptoServiceProvider();
            //string HashUsername=
                sHA1.ComputeHash(Encoding.UTF8.GetBytes(username));
            Preferences.Set("Login", username);
            Preferences.Set("Password", password);
            Navigation.PopModalAsync();
        }
        static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] uintBuffer = new byte[sizeof(uint)];
                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            return res.ToString();
        }
    }
}