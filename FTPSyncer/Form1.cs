using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FTPSyncer
{
    public partial class Form1 : Form
    {
        private Model model;

        public Form1()
        {
            InitializeComponent();
            model = new Model();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //restore coulm settings
            try
            {
                object value = Properties.Settings.Default["TableColums"];
                byte[] arr = ((String)value).Split(',').Select(s => Byte.Parse(s)).ToArray();
                fastObjectListView1.RestoreState(arr);
            }
            catch (Exception err)
            {
                Logger.log("Could not restore table state: " + err.Message);
            }

            //restore window Bounds
            var savedBounds = (Rectangle)Properties.Settings.Default["MainWindowBounds"];
            if (savedBounds.Width > 0 && savedBounds.Height > 0)
                this.Bounds = savedBounds;


            //load Saved SyncFolders
            model.load((String)Properties.Settings.Default["SaveFile"]);
            fastObjectListView1.SetObjects(model.getAll());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save Table Column state
            try
            {
                string value = String.Join(",", fastObjectListView1.SaveState().Select(i => i.ToString()).ToArray());
                Properties.Settings.Default["TableColums"] = value;
            }
            catch (Exception err)
            {
                Logger.log("Could not save table state: " + err.Message);
            }

            //Save Window Bounds
            Properties.Settings.Default["MainWindowBounds"] = this.Bounds;

            //save everything
            Properties.Settings.Default.Save();
            model.save((String)Properties.Settings.Default["SaveFile"]);
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            var dialog = new EditDialog(new SyncFolder());
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                model.addSyncFolder(dialog.SyncFolder);
                fastObjectListView1.AddObject(dialog.SyncFolder);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var dialog = new EditDialog((SyncFolder)fastObjectListView1.SelectedObject);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fastObjectListView1.SetObjects(model.getAll());
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            model.removeSyncFolder((SyncFolder)fastObjectListView1.SelectedObject);
            fastObjectListView1.SetObjects(model.getAll());
        }

        private void fastObjectListView1_DoubleClick(object sender, EventArgs e)
        {
            btn_edit.PerformClick();
        }

    }
}
