﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (tbUser.Text == "user" && tbPass.Text == "passw")
            {
                frmEmail form1 = new frmEmail(this);
                form1.Show();
                //this.Close();
                tbUser.Text = "";
                tbPass.Text = "";
                lbPoruka.Text = "";
                
            }
            else if (tbUser.Text == "user" && tbPass.Text != "passw")
            {
                lbPoruka.Text = "Pogresna sifra!";
            }
            else if (tbUser.Text == "user" && tbPass.Text == "passw")
            {
                frmEmail form1 = new frmEmail(this);
                form1.Show();
                tbUser.Text = "";
                tbPass.Text = "";
                lbPoruka.Text = "";
               
            }
            else if (tbUser.Text == "peraperictest12345@gmail.com" && tbPass.Text != "perapera1")
            {
                lbPoruka.Text = "Pogresna sifra!";
            }
            else if (tbUser.Text == "")
            {
                lbPoruka.Text = "Unestie email!";
            }
            else if (tbPass.Text == "")
            {
                lbPoruka.Text = "Unesite pasvord!";
            }
            else
            {
                lbPoruka.Text = "Pogresan email!";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbPass.UseSystemPasswordChar = true;
        }
        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPass.UseSystemPasswordChar = true;
            }
        }

        
    }
}
