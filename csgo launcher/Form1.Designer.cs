
namespace csgo_launcher
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.SteamDirectory = new System.Windows.Forms.TextBox();
            this.LaunchOption = new System.Windows.Forms.TextBox();
            this.SteamDirectoryLabel = new System.Windows.Forms.Label();
            this.LaunchOptionLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.ListBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DeleteID = new System.Windows.Forms.Button();
            this.AddID = new System.Windows.Forms.Button();
            this.launchCSGO = new System.Windows.Forms.CheckBox();
            this.resoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.windowed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(407, 380);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SteamDirectory
            // 
            this.SteamDirectory.Location = new System.Drawing.Point(49, 54);
            this.SteamDirectory.Name = "SteamDirectory";
            this.SteamDirectory.Size = new System.Drawing.Size(220, 27);
            this.SteamDirectory.TabIndex = 1;
            this.SteamDirectory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LaunchOption
            // 
            this.LaunchOption.Location = new System.Drawing.Point(307, 54);
            this.LaunchOption.Name = "LaunchOption";
            this.LaunchOption.Size = new System.Drawing.Size(212, 27);
            this.LaunchOption.TabIndex = 2;
            this.LaunchOption.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SteamDirectoryLabel
            // 
            this.SteamDirectoryLabel.AutoSize = true;
            this.SteamDirectoryLabel.Location = new System.Drawing.Point(46, 31);
            this.SteamDirectoryLabel.Name = "SteamDirectoryLabel";
            this.SteamDirectoryLabel.Size = new System.Drawing.Size(114, 20);
            this.SteamDirectoryLabel.TabIndex = 3;
            this.SteamDirectoryLabel.Text = "Steam directory";
            // 
            // LaunchOptionLabel
            // 
            this.LaunchOptionLabel.AutoSize = true;
            this.LaunchOptionLabel.Location = new System.Drawing.Point(304, 31);
            this.LaunchOptionLabel.Name = "LaunchOptionLabel";
            this.LaunchOptionLabel.Size = new System.Drawing.Size(103, 20);
            this.LaunchOptionLabel.TabIndex = 4;
            this.LaunchOptionLabel.Text = "Launch option";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.White;
            this.idBox.FormattingEnabled = true;
            this.idBox.ItemHeight = 20;
            this.idBox.Location = new System.Drawing.Point(49, 248);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(301, 284);
            this.idBox.TabIndex = 5;
            this.idBox.SelectedIndexChanged += new System.EventHandler(this.idBox_SelectedIndexChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(50, 164);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(220, 27);
            this.Password.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(49, 112);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(220, 27);
            this.Username.TabIndex = 8;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(46, 89);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.Username_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(46, 143);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.Password_Click);
            // 
            // DeleteID
            // 
            this.DeleteID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteID.Location = new System.Drawing.Point(407, 324);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(97, 29);
            this.DeleteID.TabIndex = 11;
            this.DeleteID.Text = "Delete";
            this.DeleteID.UseVisualStyleBackColor = true;
            this.DeleteID.Click += new System.EventHandler(this.DeleteID_Click);
            // 
            // AddID
            // 
            this.AddID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddID.Location = new System.Drawing.Point(118, 207);
            this.AddID.Name = "AddID";
            this.AddID.Size = new System.Drawing.Size(78, 28);
            this.AddID.TabIndex = 12;
            this.AddID.Text = "Add";
            this.AddID.UseVisualStyleBackColor = true;
            this.AddID.Click += new System.EventHandler(this.AddID_Click);
            // 
            // launchCSGO
            // 
            this.launchCSGO.AutoSize = true;
            this.launchCSGO.Location = new System.Drawing.Point(388, 173);
            this.launchCSGO.Name = "launchCSGO";
            this.launchCSGO.Size = new System.Drawing.Size(116, 24);
            this.launchCSGO.TabIndex = 13;
            this.launchCSGO.Text = "Launch CSGO";
            this.launchCSGO.UseVisualStyleBackColor = true;
            // 
            // resoComboBox
            // 
            this.resoComboBox.FormattingEnabled = true;
            this.resoComboBox.Location = new System.Drawing.Point(388, 108);
            this.resoComboBox.Name = "resoComboBox";
            this.resoComboBox.Size = new System.Drawing.Size(131, 28);
            this.resoComboBox.TabIndex = 14;
            this.resoComboBox.SelectedIndexChanged += new System.EventHandler(this.resoComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Resolution";
            // 
            // windowed
            // 
            this.windowed.AutoSize = true;
            this.windowed.Location = new System.Drawing.Point(388, 143);
            this.windowed.Name = "windowed";
            this.windowed.Size = new System.Drawing.Size(100, 24);
            this.windowed.TabIndex = 16;
            this.windowed.Text = "Windowed";
            this.windowed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(576, 578);
            this.Controls.Add(this.windowed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resoComboBox);
            this.Controls.Add(this.launchCSGO);
            this.Controls.Add(this.AddID);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.LaunchOptionLabel);
            this.Controls.Add(this.SteamDirectoryLabel);
            this.Controls.Add(this.LaunchOption);
            this.Controls.Add(this.SteamDirectory);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "CSGO Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SteamDirectory;
        private System.Windows.Forms.TextBox LaunchOption;
        private System.Windows.Forms.Label SteamDirectoryLabel;
        private System.Windows.Forms.Label LaunchOptionLabel;
        private System.Windows.Forms.ListBox idBox;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button DeleteID;
        private System.Windows.Forms.Button AddID;
        private System.Windows.Forms.CheckBox launchCSGO;
        private System.Windows.Forms.ComboBox resoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox windowed;
    }
}

