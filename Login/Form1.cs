using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool valid_username = true;
        bool valid_password = false;
        private void TextBox2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.DeepSkyBlue;
            label1.ForeColor = Color.DeepSkyBlue;

            panel3.BackColor = Color.Gray;
            label2.ForeColor = Color.Gray;
        }


        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (InvalidPassword())
            {
                panel3.BackColor = Color.Red;
                label2.ForeColor = Color.Red;
            }
            else
            {
                panel3.BackColor = Color.Green;
                label2.ForeColor = Color.Green;
                SetVisible();
            }

            panel2.BackColor = Color.Gray;
            label1.ForeColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left -= 100;
            t.Start();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            DataSet data = Server.getData(tb_username.Text);
            if(data.Tables["User_Info"].Rows.Count != 1)
            {
                MessageBox.Show("olmadı");
            }
            else
            {
                if (data.Tables["User_Info"].Rows[0].ItemArray[2].ToString() == Encryption.encrypt(tb_password.Text))
                {
                    MessageBox.Show(data.Tables["User_Info"].Rows[0].ItemArray[0].ToString() + " Giriş Yaptı. ", "Hoş Geldiniz");
                    Process.Start(@"C:\Users\musta\source\repos\LocalDataBaseApp\LocalDataBaseApp\bin\Debug\LocalDataBaseApp.exe");
                    t.Start();
                }
                else
                    MessageBox.Show("Bu sen değilsin ama");
            }
        }

        private void Tb_password_TextChanged(object sender, EventArgs e)
        {
            if (cb_show.Checked) tb_password.PasswordChar = '\0';
            else tb_password.PasswordChar = '*';

            if (InvalidPassword())
            {
                panel3.BackColor = Color.Red;
                label2.ForeColor = Color.Red;
            }
            else
            {
                panel3.BackColor = Color.Green;
                label2.ForeColor = Color.Green;
                SetVisible();
            }
        }

        private bool InvalidPassword()
        {
            valid_password = !(tb_password.Text.Length < 6 || tb_password.Text.Contains(" "));
            return !valid_password;
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            if (sign.ShowDialog() == DialogResult.OK)
            {
                tb_username.Text = sign.username;
                tb_password.Text = sign.password;
            }
        }

        private void SetVisible()
        {
            btn_login.Enabled = valid_password && valid_username;
        }

        private void Cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show.Checked) tb_password.PasswordChar = '\0';
            else tb_password.PasswordChar = '*';
        }

        private void Close_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Btn_close_MouseHover(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Properties.Resources.close_button;
        }

        private void Btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Properties.Resources.close_button1;
        }

        private void Btn_close_MouseMove(object sender, MouseEventArgs e)
        {
            btn_close.BackgroundImage = Properties.Resources.close_button;
        }

        bool drag = false;
        Point star_point = new Point(0, 0);
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            star_point = new Point(e.X, e.Y);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - star_point.X, p.Y - star_point.Y);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void close(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
                this.Left -= 5;
            }
            else
            {
                t.Stop();
                this.Dispose();
            }
        }

        private void open(object sender, EventArgs e)
        {
            if (this.Opacity <= 0.95)
            {
                this.Opacity += 0.05;
                this.Left += 5;
            }
            else
            {
                t.Stop();
                this.Opacity = 1;
                t.Tick -= new EventHandler(open);
                t.Tick += new EventHandler(close);
            }

        }

        private void Tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login.PerformClick();
            else if (e.KeyCode == Keys.Delete)
                ((TextBox)sender).Text = "";
        }

        private void Tb_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("\t");
        }

        private void Tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space)) { }
        }

    }
}
