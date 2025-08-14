﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxQuest.KeyDown += TbxQuest_KeyDown;
        }

        private void TbxQuest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lblAnswer.Text += tbxQuest.Text + Environment.NewLine;
                tbxQuest.Text = string.Empty;
                e.SuppressKeyPress = true;
            }
        }
    }
}
