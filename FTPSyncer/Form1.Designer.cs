namespace FTPSyncer
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
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.fastObjectListView1 = new BrightIdeasSoftware.FastObjectListView();
            this.head_localPath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_remotePath = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_server = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_port = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_protocol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_Username = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_syncMode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_lastSync = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_checkChangesMode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.head_lastCheck = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_del.Location = new System.Drawing.Point(403, 70);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 1;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(403, 41);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(403, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // fastObjectListView1
            // 
            this.fastObjectListView1.AllColumns.Add(this.head_localPath);
            this.fastObjectListView1.AllColumns.Add(this.head_remotePath);
            this.fastObjectListView1.AllColumns.Add(this.head_server);
            this.fastObjectListView1.AllColumns.Add(this.head_port);
            this.fastObjectListView1.AllColumns.Add(this.head_protocol);
            this.fastObjectListView1.AllColumns.Add(this.head_Username);
            this.fastObjectListView1.AllColumns.Add(this.head_syncMode);
            this.fastObjectListView1.AllColumns.Add(this.head_lastSync);
            this.fastObjectListView1.AllColumns.Add(this.head_checkChangesMode);
            this.fastObjectListView1.AllColumns.Add(this.head_lastCheck);
            this.fastObjectListView1.AllowColumnReorder = true;
            this.fastObjectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastObjectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.head_localPath,
            this.head_remotePath,
            this.head_server,
            this.head_port,
            this.head_protocol,
            this.head_Username,
            this.head_syncMode,
            this.head_lastSync,
            this.head_checkChangesMode,
            this.head_lastCheck});
            this.fastObjectListView1.FullRowSelect = true;
            this.fastObjectListView1.Location = new System.Drawing.Point(12, 12);
            this.fastObjectListView1.MultiSelect = false;
            this.fastObjectListView1.Name = "fastObjectListView1";
            this.fastObjectListView1.ShowGroups = false;
            this.fastObjectListView1.Size = new System.Drawing.Size(385, 282);
            this.fastObjectListView1.TabIndex = 2;
            this.fastObjectListView1.UseCompatibleStateImageBehavior = false;
            this.fastObjectListView1.View = System.Windows.Forms.View.Details;
            this.fastObjectListView1.VirtualMode = true;
            this.fastObjectListView1.DoubleClick += new System.EventHandler(this.fastObjectListView1_DoubleClick);
            // 
            // head_localPath
            // 
            this.head_localPath.AspectName = "LocalPath";
            this.head_localPath.Text = "Local Path";
            // 
            // head_remotePath
            // 
            this.head_remotePath.AspectName = "ServerPath";
            this.head_remotePath.Text = "Remote Path";
            // 
            // head_server
            // 
            this.head_server.AspectName = "Server";
            this.head_server.Text = "Server Address";
            // 
            // head_port
            // 
            this.head_port.AspectName = "Port";
            this.head_port.Text = "Port";
            // 
            // head_protocol
            // 
            this.head_protocol.AspectName = "Protocol";
            this.head_protocol.Text = "Protocol";
            // 
            // head_Username
            // 
            this.head_Username.AspectName = "Username";
            this.head_Username.Text = "Username";
            // 
            // head_syncMode
            // 
            this.head_syncMode.Text = "Syncronize Interval";
            // 
            // head_lastSync
            // 
            this.head_lastSync.AspectName = "LastSync";
            this.head_lastSync.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
            this.head_lastSync.IsEditable = false;
            this.head_lastSync.Text = "last syncronice";
            // 
            // head_checkChangesMode
            // 
            this.head_checkChangesMode.Text = "Check Change Interval";
            // 
            // head_lastCheck
            // 
            this.head_lastCheck.AspectName = "lastChangeCheck";
            this.head_lastCheck.AspectToStringFormat = "{0:yyyy-MM-dd HH:mm}";
            this.head_lastCheck.IsEditable = false;
            this.head_lastCheck.Text = "last Chagecheck";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 306);
            this.Controls.Add(this.fastObjectListView1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_del);
            this.Name = "Form1";
            this.Text = "FTP Syncer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastObjectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private BrightIdeasSoftware.FastObjectListView fastObjectListView1;
        private BrightIdeasSoftware.OLVColumn head_localPath;
        private BrightIdeasSoftware.OLVColumn head_remotePath;
        private BrightIdeasSoftware.OLVColumn head_server;
        private BrightIdeasSoftware.OLVColumn head_port;
        private BrightIdeasSoftware.OLVColumn head_protocol;
        private BrightIdeasSoftware.OLVColumn head_syncMode;
        private BrightIdeasSoftware.OLVColumn head_lastSync;
        private BrightIdeasSoftware.OLVColumn head_checkChangesMode;
        private BrightIdeasSoftware.OLVColumn head_lastCheck;
        private BrightIdeasSoftware.OLVColumn head_Username;
    }
}

