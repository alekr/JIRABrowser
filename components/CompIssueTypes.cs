using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using JIRA.classes;

namespace JIRA.components
{
    public partial class CompIssueTypes : UserControl
    {
        private CJiraProject project;

        public CompIssueTypes()
        {
            InitializeComponent();
        }

        public void SetProject(CJiraProject project)
        {
            this.project = project;

            foreach (CJiraIssuetype issueType in project.issuetypes)
            {
                listView1.Items.Add(issueType.name);
            }
        }
    }
}
