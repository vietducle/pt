﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace photo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStatusStrip(null);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File";
            dlg.Filter = "jpg files (*.jpg) |*.jpg| All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                try
                {
                    pbxPhoto.Image = new Bitmap(dlg.OpenFile());
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Unable to load file:" + ex.Message);
                    pbxPhoto.Image = null;
                }
            SetStatusStrip(dlg.FileName);
            
            dlg.Dispose();

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mnuImage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProcessImageClick(e);
        }
        private void ProcessImageClick( ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string enumVal = item.Tag as string;
            if (enumVal != null)
            {
                pbxPhoto.SizeMode = (PictureBoxSizeMode)
                    Enum.Parse(typeof(PictureBoxSizeMode), enumVal);
            }
        }
        private void mnuImage_DropDownOpening(object sender, EventArgs e)
        {
            ProcessImageOpening(sender as ToolStripDropDownItem);
        }

        private void ProcessImageOpening(ToolStripDropDownItem parent)
        {
            if (parent != null)
            {
                string enumVal = pbxPhoto.SizeMode.ToString();
                foreach(ToolStripMenuItem item in parent.DropDownItems)
                {
                    item.Enabled = (pbxPhoto.Image !=null);
                    item.Checked = item.Tag.Equals(enumVal);
                }
            }
        }
        private void SetStatusStrip(string path)
        {
            if (pbxPhoto.Image != null)
            {
                statusInfo.Text = path;
                statusImageSize.Text = String.Format("{0:#}x{1:#}", pbxPhoto.Image.Width, pbxPhoto.Image.Height);
            }
            else
            {
                statusInfo.Text = null;
                statusImageSize.Text = null;
                statusAlbumPos.Text = null;
            }
        }

        

    }
}
