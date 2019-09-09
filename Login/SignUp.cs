using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class SignUp : Form
    {
        public string username;
        public string password;
        bool valid_username = false;
        bool valid_password = false;

        public SignUp()
        {
            InitializeComponent();
        }

        private void Tb_user_TextChanged(object sender, EventArgs e)
        {
            DataSet data = Server.getData(tb_user.Text);
            if(data.Tables["User_Info"].Rows.Count > 0 || tb_user.Text.Length<1)
            {
                panel2.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                valid_username = false;
            }
            else
            {
                panel2.BackColor = Color.Green;
                label1.ForeColor = Color.Green;
                valid_username = true;
            }
            SetVisible();
        }

        private void Tb_name_TextChanged(object sender, EventArgs e)
        {
            if (tb_name.Text.Length > 0)
            {
                panel4.BackColor = Color.Green;
                label3.ForeColor = Color.Green;
            }
            else
            {
                panel4.BackColor = Color.Red;
                label3.ForeColor = Color.Red;
            }
            SetVisible();
        }

        private void SetVisible()
        {
            btn_signup.Enabled = (valid_username && valid_password && tb_surname.Text.Length > 0 && tb_name.Text.Length > 0);
        }
        private void Tb_surname_TextChanged(object sender, EventArgs e)
        {
            if (tb_surname.Text.Length > 0)
            {
                panel5.BackColor = Color.Green;
                label4.ForeColor = Color.Green;
            }
            else
            {
                panel5.BackColor = Color.Red;
                label4.ForeColor = Color.Red;
            }
            SetVisible();
        }

        private void Tb_pass_TextChanged(object sender, EventArgs e)
        {
            if (cb_show_pass.Checked) tb_pass.PasswordChar = '\0';
            else tb_pass.PasswordChar = '*';

            if (InvalidPassword())
            {
                panel6.BackColor = Color.Red;
                label2.ForeColor = Color.Red;
            }
            else
            {
                panel6.BackColor = Color.Green;
                label2.ForeColor = Color.Green;
                SetVisible();
            }
            
        }

        private bool InvalidPassword()
        {
            valid_password = !(tb_pass.Text.Length < 6 || tb_pass.Text.Contains(" "));
            return !valid_password;
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                Server.insert("Insert into User_Info (Name,Surname,Username,Password) Values ('" + tb_name.Text + "','" + tb_surname.Text + "','" + tb_user.Text + "','" + Encryption.encrypt(tb_pass.Text) + "')");
                username = tb_user.Text;
                password = tb_pass.Text;
                MessageBox.Show("Yeni Kullanıcı Eklendi!!");
                t.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            
        }

        private void Cb_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show_pass.Checked) tb_pass.PasswordChar = '\0';
            else tb_pass.PasswordChar = '*';
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

        private void Btn_close_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void close(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                Console.WriteLine("buradayım");
                this.Opacity -= 0.05;
                this.Left -= 5;
            }
            else
            {
                t.Stop();
                this.Dispose();
            }
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

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.Left -= 100;
            t.Start();
        }

        //fade in/away effect
        private void open(object sender, EventArgs e)
        {
            if (this.Opacity <= 0.95)
            {
                this.Left += 5;
                this.Opacity += 0.05;
            }
            else
            {
                t.Stop();
                this.Opacity = 1;
                t.Tick -= new EventHandler(open);
                t.Tick += new EventHandler(close);
            }

        }
    }
}
