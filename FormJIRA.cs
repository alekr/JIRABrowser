using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;

using JIRA.classes;

namespace JIRA
{
    public partial class FormJIRA : Form
    {
        CUser user = null;

        public FormJIRA()
        {
            InitializeComponent();
        }

        private void OnLogin(object sender, EventArgs e)
        {
            if (compLogin1.LoggedIn == false)
            {
                user = compLogin1.Login();
                if (user != null)
                {
                    toolStripLabelUser.Text = user.UserName;
                    butLogin.Text = butLogin.ToolTipText = "Log out";
                    butLogin.Image = global::JIRA.Properties.Resources.logout;

                    compLogin1.Visible = false;
                    FormBorderStyle = FormBorderStyle.Sizable;
                }
            }
            else
            {
                compLogin1.Logout();
                user = null;

                toolStripLabelUser.Text = "Logged out";
                butLogin.Text = butLogin.ToolTipText = "Log in";
                butLogin.Image = global::JIRA.Properties.Resources.login;

                this.Width = 540;
                this.Height = 430;

                FormBorderStyle = FormBorderStyle.FixedDialog;
                compLogin1.Visible = true;
            }
        }
    }
}
