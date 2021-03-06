﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST
{
    public partial class RenamePresetDialog : Form
    {
        private RenamePresetDialog()
        {
            InitializeComponent();
        }

        public static string ExecuteDialog(string name)
        {
            using (RenamePresetDialog dlg = new RenamePresetDialog())
            {
                dlg.txtName.Text = name;
                if (dlg.ShowDialog() == DialogResult.OK)
                    return dlg.txtName.Text;
                else
                    return null;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (txtName.Text.Length > 1);
        }
    }
}
