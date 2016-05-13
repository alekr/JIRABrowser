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

            this.Width = 540;
            this.Height = 430;

            panelComponents.Visible = false;
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
                    butLogin.Image = global::JIRA.Properties.Resources.login;

                    foreach (CJiraProject project in user.Projects)
                    {
                        toolStripComboBox1.Items.Add(project.key);
                    }

                    compLogin1.Visible = false;
                    panelComponents.Visible = true;
                    FormBorderStyle = FormBorderStyle.Sizable;

                    DisplayProject();
                }
            }
            else
            {
                compLogin1.Logout();
                user = null;

                toolStripLabelUser.Text = "    ";
                butLogin.Text = butLogin.ToolTipText = "Log in";
                butLogin.Image = global::JIRA.Properties.Resources.login;

                this.Width = 540;
                this.Height = 430;

                FormBorderStyle = FormBorderStyle.FixedDialog;
                compLogin1.Visible = true;
                panelComponents.Visible = false;
            }
        }

        private void DisplayProject()
        {
            if (toolStripComboBox1.Items.Count > 0)
            {
                toolStripComboBox1.SelectedIndex = 0;
                CJiraProject project = GetProject(0);

                if (project != null)
                    compIssueTypes1.SetProject(project);
            }
        }

        private CJiraProject GetProject(int index)
        {
            int i = 0;
            foreach (CJiraProject project in user.Projects)
            {
                if (i == index)
                    return project;
                i++;
            }

            return null;
        }

    }
}
