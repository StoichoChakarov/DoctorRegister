﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorRegister.Views
{
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsernameR.Clear();
            txtPasswordR.Clear();
            txtConfirmPasswordR.Clear();
            txtUsernameR.Focus();
        }
    }
}
