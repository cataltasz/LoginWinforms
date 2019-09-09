namespace Login
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.cb_show_pass = new System.Windows.Forms.CheckBox();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 79);
            this.panel1.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::Login.Properties.Resources.close_button1;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(242, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 24;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            this.btn_close.MouseLeave += new System.EventHandler(this.Btn_close_MouseLeave);
            this.btn_close.MouseHover += new System.EventHandler(this.Btn_close_MouseHover);
            this.btn_close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_close_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_signup.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_signup.Location = new System.Drawing.Point(107, 372);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 31);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(41, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(41, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // tb_password
            // 
            this.tb_password.AcceptsReturn = true;
            this.tb_password.BackColor = System.Drawing.SystemColors.Control;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_password.Location = new System.Drawing.Point(35, 288);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(215, 18);
            this.tb_password.TabIndex = 8;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.SystemColors.Control;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_username.Location = new System.Drawing.Point(35, 288);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(215, 18);
            this.tb_username.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(35, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 1);
            this.panel6.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(35, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(41, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(35, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 18);
            this.textBox1.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(35, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 1);
            this.panel4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(41, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Surname";
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.SystemColors.Control;
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_pass.Location = new System.Drawing.Point(35, 287);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(215, 18);
            this.tb_pass.TabIndex = 3;
            this.tb_pass.TextChanged += new System.EventHandler(this.Tb_pass_TextChanged);
            this.tb_pass.Enter += new System.EventHandler(this.Tb_pass_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(35, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 1);
            this.panel5.TabIndex = 18;
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.SystemColors.Control;
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_user.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_user.Location = new System.Drawing.Point(35, 142);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(215, 18);
            this.tb_user.TabIndex = 0;
            this.tb_user.TextChanged += new System.EventHandler(this.Tb_user_TextChanged);
            this.tb_user.Enter += new System.EventHandler(this.Tb_user_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.SystemColors.Control;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_name.Location = new System.Drawing.Point(35, 190);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(215, 18);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.Tb_name_TextChanged);
            this.tb_name.Enter += new System.EventHandler(this.Tb_name_TextChanged);
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.SystemColors.Control;
            this.tb_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_surname.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_surname.Location = new System.Drawing.Point(32, 239);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(215, 18);
            this.tb_surname.TabIndex = 2;
            this.tb_surname.TextChanged += new System.EventHandler(this.Tb_surname_TextChanged);
            this.tb_surname.Enter += new System.EventHandler(this.Tb_surname_TextChanged);
            // 
            // cb_show_pass
            // 
            this.cb_show_pass.AutoSize = true;
            this.cb_show_pass.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_show_pass.FlatAppearance.BorderSize = 3;
            this.cb_show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_show_pass.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_show_pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb_show_pass.Location = new System.Drawing.Point(95, 330);
            this.cb_show_pass.Name = "cb_show_pass";
            this.cb_show_pass.Size = new System.Drawing.Size(97, 16);
            this.cb_show_pass.TabIndex = 23;
            this.cb_show_pass.Text = "Show Password";
            this.cb_show_pass.UseVisualStyleBackColor = true;
            this.cb_show_pass.CheckedChanged += new System.EventHandler(this.Cb_show_pass_CheckedChanged);
            // 
            // t
            // 
            this.t.Interval = 5;
            this.t.Tick += new System.EventHandler(this.open);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.cb_show_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.CheckBox cb_show_pass;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Timer t;
    }
}