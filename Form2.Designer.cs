
namespace Password_Manager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lbltitle = new Label();
            lblusername = new Label();
            lblemail = new Label();
            lblpassword = new Label();
            rdofemale = new RadioButton();
            rdomale = new RadioButton();
            lblgender = new Label();
            cbocountry = new ComboBox();
            lblcountry = new Label();
            cbophone = new ComboBox();
            lblphone = new Label();
            txtphone = new TextBox();
            txtusername = new TextBox();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            btnsignup = new Button();
            lblcheckusername = new Label();
            lblcheckemail = new Label();
            lblcheckpassword = new Label();
            lblcheckphone = new Label();
            lblcheckgender = new Label();
            lblcheckcountry = new Label();
            panel1 = new Panel();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitle
            // 
            resources.ApplyResources(lbltitle, "lbltitle");
            lbltitle.Name = "lbltitle";
            lbltitle.Click += label1_Click;
            // 
            // lblusername
            // 
            resources.ApplyResources(lblusername, "lblusername");
            lblusername.ForeColor = SystemColors.ControlText;
            lblusername.Name = "lblusername";
            // 
            // lblemail
            // 
            resources.ApplyResources(lblemail, "lblemail");
            lblemail.Name = "lblemail";
            // 
            // lblpassword
            // 
            resources.ApplyResources(lblpassword, "lblpassword");
            lblpassword.Name = "lblpassword";
            lblpassword.Click += label4_Click;
            // 
            // rdofemale
            // 
            resources.ApplyResources(rdofemale, "rdofemale");
            rdofemale.Name = "rdofemale";
            rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            resources.ApplyResources(rdomale, "rdomale");
            rdomale.Name = "rdomale";
            rdomale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            resources.ApplyResources(lblgender, "lblgender");
            lblgender.Name = "lblgender";
            // 
            // cbocountry
            // 
            cbocountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocountry.FormattingEnabled = true;
            cbocountry.Items.AddRange(new object[] { resources.GetString("cbocountry.Items"), resources.GetString("cbocountry.Items1"), resources.GetString("cbocountry.Items2"), resources.GetString("cbocountry.Items3"), resources.GetString("cbocountry.Items4"), resources.GetString("cbocountry.Items5"), resources.GetString("cbocountry.Items6"), resources.GetString("cbocountry.Items7"), resources.GetString("cbocountry.Items8"), resources.GetString("cbocountry.Items9") });
            resources.ApplyResources(cbocountry, "cbocountry");
            cbocountry.Name = "cbocountry";
            // 
            // lblcountry
            // 
            resources.ApplyResources(lblcountry, "lblcountry");
            lblcountry.Name = "lblcountry";
            // 
            // cbophone
            // 
            cbophone.BackColor = SystemColors.Window;
            cbophone.DropDownStyle = ComboBoxStyle.DropDownList;
            cbophone.FormattingEnabled = true;
            cbophone.Items.AddRange(new object[] { resources.GetString("cbophone.Items"), resources.GetString("cbophone.Items1"), resources.GetString("cbophone.Items2"), resources.GetString("cbophone.Items3"), resources.GetString("cbophone.Items4"), resources.GetString("cbophone.Items5"), resources.GetString("cbophone.Items6"), resources.GetString("cbophone.Items7") });
            resources.ApplyResources(cbophone, "cbophone");
            cbophone.Name = "cbophone";
            cbophone.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblphone
            // 
            resources.ApplyResources(lblphone, "lblphone");
            lblphone.Name = "lblphone";
            // 
            // txtphone
            // 
            resources.ApplyResources(txtphone, "txtphone");
            txtphone.Name = "txtphone";
            txtphone.TextChanged += textBox1_TextChanged;
            // 
            // txtusername
            // 
            resources.ApplyResources(txtusername, "txtusername");
            txtusername.Name = "txtusername";
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtemail
            // 
            resources.ApplyResources(txtemail, "txtemail");
            txtemail.Name = "txtemail";
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // txtpassword
            // 
            resources.ApplyResources(txtpassword, "txtpassword");
            txtpassword.Name = "txtpassword";
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.DarkOrange;
            btnsignup.Cursor = Cursors.Hand;
            btnsignup.FlatAppearance.BorderColor = Color.DarkOrange;
            btnsignup.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            btnsignup.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            resources.ApplyResources(btnsignup, "btnsignup");
            btnsignup.ForeColor = SystemColors.ControlLightLight;
            btnsignup.Name = "btnsignup";
            btnsignup.UseVisualStyleBackColor = false;
            btnsignup.Click += btnsignup_Click;
            // 
            // lblcheckusername
            // 
            resources.ApplyResources(lblcheckusername, "lblcheckusername");
            lblcheckusername.ForeColor = Color.ForestGreen;
            lblcheckusername.Name = "lblcheckusername";
            lblcheckusername.Click += lblcheckusername_Click;
            // 
            // lblcheckemail
            // 
            resources.ApplyResources(lblcheckemail, "lblcheckemail");
            lblcheckemail.ForeColor = Color.ForestGreen;
            lblcheckemail.Name = "lblcheckemail";
            // 
            // lblcheckpassword
            // 
            resources.ApplyResources(lblcheckpassword, "lblcheckpassword");
            lblcheckpassword.ForeColor = Color.ForestGreen;
            lblcheckpassword.Name = "lblcheckpassword";
            // 
            // lblcheckphone
            // 
            resources.ApplyResources(lblcheckphone, "lblcheckphone");
            lblcheckphone.ForeColor = Color.ForestGreen;
            lblcheckphone.Name = "lblcheckphone";
            // 
            // lblcheckgender
            // 
            resources.ApplyResources(lblcheckgender, "lblcheckgender");
            lblcheckgender.ForeColor = Color.ForestGreen;
            lblcheckgender.Name = "lblcheckgender";
            // 
            // lblcheckcountry
            // 
            resources.ApplyResources(lblcheckcountry, "lblcheckcountry");
            lblcheckcountry.ForeColor = Color.ForestGreen;
            lblcheckcountry.Name = "lblcheckcountry";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(rdomale);
            panel1.Controls.Add(rdofemale);
            panel1.Controls.Add(lblcheckgender);
            panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Name = "label3";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbltitle);
            panel2.Cursor = Cursors.Hand;
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SandyBrown;
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.ForeColor = Color.MediumBlue;
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(checkBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(btnsignup);
            Controls.Add(lblcheckcountry);
            Controls.Add(lblcheckphone);
            Controls.Add(lblcheckpassword);
            Controls.Add(lblcheckemail);
            Controls.Add(lblcheckusername);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(txtusername);
            Controls.Add(txtphone);
            Controls.Add(lblphone);
            Controls.Add(cbophone);
            Controls.Add(lblcountry);
            Controls.Add(cbocountry);
            Controls.Add(lblgender);
            Controls.Add(lblpassword);
            Controls.Add(lblemail);
            Controls.Add(lblusername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lbltitle;
        private Label lblusername;
        private Label lblemail;
        private Label lblpassword;
        private RadioButton rdofemale;
        private RadioButton rdomale;
        private Label lblgender;
        private ComboBox cbocountry;
        private Label lblcountry;
        private ComboBox cbophone;
        private Label lblphone;
        private TextBox txtphone;
        private TextBox txtusername;
        private TextBox txtemail;
        private TextBox txtpassword;
        private Button btnsignup;
        private Label lblcheckusername;
        private Label lblcheckemail;
        private Label lblcheckpassword;
        private Label lblcheckphone;
        private Label lblcheckgender;
        private Label lblcheckcountry;
        private Panel panel1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private CheckBox checkBox1;
    }
}