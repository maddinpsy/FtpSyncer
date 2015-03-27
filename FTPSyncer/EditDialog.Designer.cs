namespace FTPSyncer
{
    partial class EditDialog
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
            this.tb_local = new System.Windows.Forms.TextBox();
            this.lbl_Local = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_remote = new System.Windows.Forms.TextBox();
            this.lbl_Remote = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Protocol = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_openLocalPath = new System.Windows.Forms.Button();
            this.combo_Proto = new System.Windows.Forms.ComboBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_local
            // 
            this.tb_local.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_local.Location = new System.Drawing.Point(89, 12);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(418, 20);
            this.tb_local.TabIndex = 0;
            // 
            // lbl_Local
            // 
            this.lbl_Local.AutoSize = true;
            this.lbl_Local.Location = new System.Drawing.Point(10, 16);
            this.lbl_Local.Name = "lbl_Local";
            this.lbl_Local.Size = new System.Drawing.Size(58, 13);
            this.lbl_Local.TabIndex = 1;
            this.lbl_Local.Text = "Local Path";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(453, 209);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(372, 208);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tb_remote
            // 
            this.tb_remote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_remote.Location = new System.Drawing.Point(89, 38);
            this.tb_remote.Name = "tb_remote";
            this.tb_remote.Size = new System.Drawing.Size(439, 20);
            this.tb_remote.TabIndex = 2;
            // 
            // lbl_Remote
            // 
            this.lbl_Remote.AutoSize = true;
            this.lbl_Remote.Location = new System.Drawing.Point(10, 42);
            this.lbl_Remote.Name = "lbl_Remote";
            this.lbl_Remote.Size = new System.Drawing.Size(69, 13);
            this.lbl_Remote.TabIndex = 1;
            this.lbl_Remote.Text = "Remote Path";
            // 
            // tb_server
            // 
            this.tb_server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_server.Location = new System.Drawing.Point(89, 64);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(439, 20);
            this.tb_server.TabIndex = 3;
            this.tb_server.Leave += new System.EventHandler(this.tb_server_Leave);
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(10, 68);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(73, 13);
            this.lbl_Server.TabIndex = 1;
            this.lbl_Server.Text = "Server Adress";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(10, 120);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(26, 13);
            this.lbl_Port.TabIndex = 1;
            this.lbl_Port.Text = "Port";
            // 
            // lbl_Protocol
            // 
            this.lbl_Protocol.AutoSize = true;
            this.lbl_Protocol.Location = new System.Drawing.Point(10, 93);
            this.lbl_Protocol.Name = "lbl_Protocol";
            this.lbl_Protocol.Size = new System.Drawing.Size(46, 13);
            this.lbl_Protocol.TabIndex = 1;
            this.lbl_Protocol.Text = "Protocol";
            // 
            // tb_user
            // 
            this.tb_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_user.Location = new System.Drawing.Point(89, 142);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(439, 20);
            this.tb_user.TabIndex = 6;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(10, 146);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(55, 13);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "Username";
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pass.Location = new System.Drawing.Point(89, 168);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(439, 20);
            this.tb_pass.TabIndex = 7;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(10, 172);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password";
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_check.Location = new System.Drawing.Point(12, 208);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(106, 23);
            this.btn_check.TabIndex = 8;
            this.btn_check.Text = "Check Connection";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_openLocalPath
            // 
            this.btn_openLocalPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_openLocalPath.Location = new System.Drawing.Point(507, 12);
            this.btn_openLocalPath.Margin = new System.Windows.Forms.Padding(0);
            this.btn_openLocalPath.Name = "btn_openLocalPath";
            this.btn_openLocalPath.Size = new System.Drawing.Size(21, 20);
            this.btn_openLocalPath.TabIndex = 1;
            this.btn_openLocalPath.Text = "...";
            this.btn_openLocalPath.UseVisualStyleBackColor = true;
            this.btn_openLocalPath.Click += new System.EventHandler(this.btn_openLocalPath_Click);
            // 
            // combo_Proto
            // 
            this.combo_Proto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_Proto.FormattingEnabled = true;
            this.combo_Proto.Items.AddRange(new object[] {
            "FTP",
            "SFTP",
            "FTPS"});
            this.combo_Proto.Location = new System.Drawing.Point(89, 89);
            this.combo_Proto.Name = "combo_Proto";
            this.combo_Proto.Size = new System.Drawing.Size(439, 21);
            this.combo_Proto.TabIndex = 5;
            this.combo_Proto.SelectedIndexChanged += new System.EventHandler(this.combo_Proto_SelectedIndexChanged);
            // 
            // lbl_output
            // 
            this.lbl_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_output.AutoSize = true;
            this.lbl_output.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_output.Location = new System.Drawing.Point(124, 213);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(0, 13);
            this.lbl_output.TabIndex = 11;
            // 
            // nud_port
            // 
            this.nud_port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_port.Location = new System.Drawing.Point(89, 116);
            this.nud_port.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(439, 20);
            this.nud_port.TabIndex = 4;
            this.nud_port.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 243);
            this.Controls.Add(this.nud_port);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.combo_Proto);
            this.Controls.Add(this.btn_openLocalPath);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_Protocol);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_Server);
            this.Controls.Add(this.lbl_Remote);
            this.Controls.Add(this.lbl_Local);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.tb_remote);
            this.Controls.Add(this.tb_local);
            this.Name = "EditDialog";
            this.Text = "EditDialog";
            this.Load += new System.EventHandler(this.EditDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_local;
        private System.Windows.Forms.Label lbl_Local;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tb_remote;
        private System.Windows.Forms.Label lbl_Remote;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Protocol;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_openLocalPath;
        private System.Windows.Forms.ComboBox combo_Proto;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}