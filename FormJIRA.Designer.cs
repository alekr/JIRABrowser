namespace JIRA
{
    partial class FormJIRA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelComponents = new System.Windows.Forms.Panel();
            this.compIssueTypes1 = new JIRA.components.CompIssueTypes();
            this.compLogin1 = new JIRA.components.CompLogin();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panelComponents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butLogin,
            this.toolStripSeparator1,
            this.toolStripLabelUser,
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 39);
            this.toolStrip1.TabIndex = 0;
            // 
            // butLogin
            // 
            this.butLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.butLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butLogin.Image = global::JIRA.Properties.Resources.login;
            this.butLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(52, 36);
            this.butLogin.Text = "Log in";
            this.butLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabelUser
            // 
            this.toolStripLabelUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelUser.Name = "toolStripLabelUser";
            this.toolStripLabelUser.Size = new System.Drawing.Size(28, 36);
            this.toolStripLabelUser.Text = "       ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 36);
            this.toolStripLabel1.Text = "Projects:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 39);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelComponents
            // 
            this.panelComponents.BackColor = System.Drawing.Color.White;
            this.panelComponents.Controls.Add(this.compIssueTypes1);
            this.panelComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComponents.Location = new System.Drawing.Point(0, 0);
            this.panelComponents.Name = "panelComponents";
            this.panelComponents.Size = new System.Drawing.Size(1076, 502);
            this.panelComponents.TabIndex = 1;
            // 
            // compIssueTypes1
            // 
            this.compIssueTypes1.Dock = System.Windows.Forms.DockStyle.Left;
            this.compIssueTypes1.Location = new System.Drawing.Point(0, 0);
            this.compIssueTypes1.Name = "compIssueTypes1";
            this.compIssueTypes1.Size = new System.Drawing.Size(219, 502);
            this.compIssueTypes1.TabIndex = 0;
            // 
            // compLogin1
            // 
            this.compLogin1.BackColor = System.Drawing.Color.White;
            this.compLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compLogin1.Location = new System.Drawing.Point(0, 0);
            this.compLogin1.Name = "compLogin1";
            this.compLogin1.Size = new System.Drawing.Size(1076, 502);
            this.compLogin1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelComponents);
            this.panel1.Controls.Add(this.compLogin1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 502);
            this.panel1.TabIndex = 2;
            // 
            // FormJIRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormJIRA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JIRA Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelComponents.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton butLogin;
        private System.Windows.Forms.Panel panelComponents;
        private components.CompLogin compLogin1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUser;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private components.CompIssueTypes compIssueTypes1;
        private System.Windows.Forms.Panel panel1;
    }
}

