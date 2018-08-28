using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Pastebin
{
    public partial class LoginForm : Form
    {
        private const string _loginURL = "https://pastebin.com/api/api_login.php";

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void buttonLogIn_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var devKey = Properties.Resources.__devKey;

            using (var client = new HttpClient())
            {
                var parameters = new Dictionary<string, string>()
                {
                    { "api_dev_key", devKey },
                    { "api_user_name", username },
                    { "api_user_password", password }
                };

                var content = new FormUrlEncodedContent(parameters);

                var response = await client.PostAsync(_loginURL, content);

                var responseString = await response.Content.ReadAsStringAsync();

                if (!responseString.Contains("API"))
                {
                    Properties.Settings.Default.__userKey = responseString;
                    Properties.Settings.Default.__userName = username;
                }
                else
                {
                    if (responseString.Contains("invalid login"))
                    {
                        MessageBox.Show("Invalid Credentials", "Error");
                    }
                    else
                    {
                        MessageBox.Show(responseString, "Error");
                    }
                }
            }
                        
        }
    }
}
