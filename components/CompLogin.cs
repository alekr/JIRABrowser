using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;

using JIRA.classes;

namespace JIRA.components
{
    public partial class CompLogin : UserControl
    {
        private CUser user = null;

        public bool LoggedIn { get; private set; }

        public CompLogin()
        {
            InitializeComponent();
        }

        public CUser Login()
        {
            if (LoggedIn)
                return null;

            OnAuthenticate(this, null);

            return user;
        }

        public bool Logout()
        {
            return true;
        }

        private void OnAuthenticate(object sender, EventArgs e)
        {
            string url = "https://" + comboBoxServer.Text + "/rest/api/2/issue/createmeta";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            string encodedCredentials = Base64Encode(txtUsername.Text + ":" + txtPassword.Text);
            request.Headers["Authorization"] = "Basic " + encodedCredentials;
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream resStream = response.GetResponseStream();

            try
            {
                LoggedIn = true;
                user = new CUser(txtUsername.Text, resStream);
            }
            catch
            {
                LoggedIn = false;
            }
        }

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void CompLogin_Load(object sender, EventArgs e)
        {
            comboBoxServer.SelectedIndex = 0;
        }
    }
}
