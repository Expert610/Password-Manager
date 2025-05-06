namespace Password_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblusername = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label1 = new Label();
            btnlogin = new Button();
            lbllink = new LinkLabel();
            label3 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            titlepanel = new Panel();
            lbltitle = new Label();
            lblexit = new Label();
            lblcheckUsername = new Label();
            lblcheckemail = new Label();
            titlepanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.AntiqueWhite;
            lblusername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.Black;
            lblusername.Location = new Point(340, 96);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(104, 28);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username";
            lblusername.Click += lblusername_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(461, 97);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(183, 27);
            txtusername.TabIndex = 1;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(461, 172);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(183, 27);
            txtpassword.TabIndex = 3;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(347, 172);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DarkOrange;
            btnlogin.BackgroundImageLayout = ImageLayout.None;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderColor = Color.DarkOrange;
            btnlogin.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            btnlogin.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnlogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ControlLightLight;
            btnlogin.Location = new Point(403, 237);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(149, 40);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnsubmit_Click;
            btnlogin.MouseClick += btnsubmit_MouseClick;
            btnlogin.MouseHover += btnsubmit_MouseHover;
            // 
            // lbllink
            // 
            lbllink.AutoSize = true;
            lbllink.Cursor = Cursors.Hand;
            lbllink.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllink.LinkColor = Color.Blue;
            lbllink.Location = new Point(509, 336);
            lbllink.Name = "lbllink";
            lbllink.Size = new Size(114, 23);
            lbllink.TabIndex = 8;
            lbllink.TabStop = true;
            lbllink.Text = "Register Here";
            lbllink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(291, 336);
            label3.Name = "label3";
            label3.Size = new Size(212, 25);
            label3.TabIndex = 9;
            label3.Text = "Don't Have An Account?";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 385);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 38);
            panel3.TabIndex = 2;
            // 
            // titlepanel
            // 
            titlepanel.BackColor = Color.SandyBrown;
            titlepanel.Controls.Add(panel3);
            titlepanel.Controls.Add(lbltitle);
            titlepanel.Controls.Add(lblexit);
            titlepanel.Cursor = Cursors.Hand;
            titlepanel.Location = new Point(0, 0);
            titlepanel.Name = "titlepanel";
            titlepanel.Size = new Size(688, 38);
            titlepanel.TabIndex = 11;
            titlepanel.Paint += panel2_Paint;
            titlepanel.MouseDown += titlepanel_MouseDown;
            titlepanel.MouseMove += titlepanel_MouseMove;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(340, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(103, 24);
            lbltitle.TabIndex = 1;
            lbltitle.Text = "Login Now";
            // 
            // lblexit
            // 
            lblexit.AutoSize = true;
            lblexit.Cursor = Cursors.Hand;
            lblexit.Font = new Font("Perpetua Titling MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblexit.Location = new Point(661, 12);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(24, 21);
            lblexit.TabIndex = 0;
            lblexit.Text = "X";
            lblexit.Click += lblexit_Click;
            // 
            // lblcheckUsername
            // 
            lblcheckUsername.AutoSize = true;
            lblcheckUsername.ForeColor = Color.ForestGreen;
            lblcheckUsername.Location = new Point(460, 123);
            lblcheckUsername.Name = "lblcheckUsername";
            lblcheckUsername.Size = new Size(0, 20);
            lblcheckUsername.TabIndex = 12;
            // 
            // lblcheckemail
            // 
            lblcheckemail.AutoSize = true;
            lblcheckemail.ForeColor = Color.ForestGreen;
            lblcheckemail.Location = new Point(461, 202);
            lblcheckemail.Name = "lblcheckemail";
            lblcheckemail.Size = new Size(0, 20);
            lblcheckemail.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            CausesValidation = false;
            ClientSize = new Size(688, 421);
            Controls.Add(lblcheckemail);
            Controls.Add(lblcheckUsername);
            Controls.Add(titlepanel);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(lbllink);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(lblusername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Load += Form1_Load;
            titlepanel.ResumeLayout(false);
            titlepanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private TextBox txtusername;
        private Button btnlogin;
        private TextBox txtpassword;
        private Label label1;
        private LinkLabel lbllink;
        private Label label3;
        private Panel panel1;
        private Panel titlepanel;
        private Label lblexit;
        private Label lbltitle;
        private Panel panel3;
        private Label lblcheckUsername;
        private Label lblcheckemail;
    }
}
