﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string btn_clicked(object sender)
        {
            var ctrl = (ToolStripMenuItem)sender;
            return ctrl.Text;
        }

        private void logInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        

            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void userManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }
    }
}