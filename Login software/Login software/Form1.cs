using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace Login_software
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;


        public Form1()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string pass = txt_password.Text;
            if (username != "" && pass != "")
                con = new OleDbConnection("Provider=Microsoft.ACE.oledb.12.0;Data Source = DBSoftware1.accdb");
            else



            {
                MessageBox.Show("Please enter your Password or Username");
            }            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con; 
            cmd.CommandText= "Select * FROM tblUsers WHERE User ='"+username + "' AND password ='" +pass +"'";
            dr = cmd.ExecuteReader(); 
            if(dr.Read() == true)
            {
                Welcome wc = new Welcome();
                wc.ShowDialog(); 
                
                    
                    }
            else
            {
                MessageBox.Show("Login Failed");

            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
    }

    }
}
