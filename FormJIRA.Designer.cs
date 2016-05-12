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
            this.toolStripLabelUser = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelComponents = new System.Windows.Forms.Panel();
            this.compLogin1 = new JIRA.components.CompLogin();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butLogin,
            this.toolStripLabelUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 54);
            this.toolStrip1.TabIndex = 0;
            // 
            // butLogin
            // 
            this.butLogin.Image = global::JIRA.Properties.Resources.login;
            this.butLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(52, 51);
            this.butLogin.Text = "Log in";
            this.butLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // toolStripLabelUser
            // 
            this.toolStripLabelUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelUser.Name = "toolStripLabelUser";
            this.toolStripLabelUser.Size = new System.Drawing.Size(68, 51);
            this.toolStripLabelUser.Text = "Logged out";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelComponents
            // 
            this.panelComponents.BackColor = System.Drawing.Color.White;
            this.panelComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComponents.Location = new System.Drawing.Point(0, 54);
            this.panelComponents.Name = "panelComponents";
            this.panelComponents.Size = new System.Drawing.Size(533, 315);
            this.panelComponents.TabIndex = 1;
            // 
            // compLogin1
            // 
            this.compLogin1.BackColor = System.Drawing.Color.White;
            this.compLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compLogin1.Location = new System.Drawing.Point(0, 54);
            this.compLogin1.Name = "compLogin1";
            this.compLogin1.Size = new System.Drawing.Size(533, 315);
            this.compLogin1.TabIndex = 0;
            // 
            // FormJIRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 391);
            this.Controls.Add(this.compLogin1);
            this.Controls.Add(this.panelComponents);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormJIRA";
            this.Text = "JIRA Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}

