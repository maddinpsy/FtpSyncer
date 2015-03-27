using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tamir.SharpSsh;

namespace FTPSyncer
{
    public partial class EditDialog : Form
    {
        #region Properties
        private SyncFolder currentSyncFolder;
        public SyncFolder SyncFolder
        {
            get
            {
                return currentSyncFolder;
            }
        }
        #endregion //properties

        #region ctor
        public EditDialog()
        {
            InitializeComponent();
        }

        public EditDialog(SyncFolder sf)
        {
            InitializeComponent();
            currentSyncFolder = sf;
            setFields();
        }
        #endregion //ctor
        

        #region events
        private void EditDialog_Load(object sender, EventArgs e)
        {
            combo_Proto.DataSource = Enum.GetValues(typeof(Protocol));
        }

        private void combo_Proto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set Port depending on protocol
            switch ((Protocol)combo_Proto.SelectedIndex)
            {
                case Protocol.FTP:
                    nud_port.Value = 21;
                    break;
                case Protocol.SFTP:
                    nud_port.Value = 22;
                    break;
                case Protocol.FTPS:
                    nud_port.Value = 21;
                    break;
            }
        }

        private void tb_server_Leave(object sender, EventArgs e)
        {
            //set protocoll depending on server adress
            if (tb_server.Text.ToUpper().Contains("SFTP"))
            {
                combo_Proto.SelectedIndex = (int)Protocol.SFTP;
            }
            else if (tb_server.Text.ToUpper().Contains("FTPS"))
            {
                combo_Proto.SelectedIndex = (int)Protocol.FTPS;
            }
            else if (tb_server.Text.ToUpper().Contains("FTP"))
            {
                combo_Proto.SelectedIndex = (int)Protocol.FTP;
            }
        }

        private void btn_openLocalPath_Click(object sender, EventArgs e)
        {
            //show open dialog
            folderBrowserDialog1.ShowDialog();
            tb_local.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!setSyncFolder())
                return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        
        #endregion //events

        #region privat Methods
        private void setFields()
        {
            tb_local.Text = currentSyncFolder.LocalPath;
            tb_remote.Text=currentSyncFolder.ServerPath ;

            tb_server.Text=currentSyncFolder.Server;
            nud_port.Value = currentSyncFolder.Port;
            combo_Proto.SelectedIndex=(int)currentSyncFolder.Protocol;

            tb_user.Text=currentSyncFolder.Username ;
            tb_pass.Text=currentSyncFolder.Password ;
        }

        private bool setSyncFolder()
        {
            if (!validateFields())
                return false;
            currentSyncFolder.LocalPath = tb_local.Text;
            currentSyncFolder.ServerPath = tb_remote.Text;
            
            currentSyncFolder.Server = tb_server.Text;
            currentSyncFolder.Port = (int)nud_port.Value;
            currentSyncFolder.Protocol = (Protocol)combo_Proto.SelectedIndex;
            
            currentSyncFolder.Username = tb_user.Text;
            currentSyncFolder.Password = tb_pass.Text;
            return true;
        }


        private bool validateFields()
        {
            //check locel Path exists
            if (!Directory.Exists(tb_local.Text))
            {
                lbl_output.ForeColor = Color.Red;
                lbl_output.Text = "Local Path not found!";
                return false;
            }
            return true;
        }

        #endregion //privat Methods

        private void btn_check_Click(object sender, EventArgs e)
        {
            SshShell ssh = new SshShell(tb_server.Text, tb_user.Text, tb_pass.Text);
            lbl_output.ForeColor = Color.Black;
            lbl_output.Text = "Connecting...";
            ssh.Connect((int)nud_port.Value);
            if (!ssh.Connected)
            {
                lbl_output.ForeColor = Color.Red;
                lbl_output.Text = "Could not Connect";
            }
            else
            {
                lbl_output.ForeColor = Color.Green;
                lbl_output.Text = "Connection OK";
            }
            ssh.Close();
        }

     

       


        

       

        


    }
}

