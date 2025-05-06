namespace Password_Manager
{
    partial class internalform

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(internalform));
            panel1 = new Panel();
            lblexit = new Label();
            label1 = new Label();
            lv = new ListView();
            columnHeader1 = new ColumnHeader();
            lblname = new Label();
            lblusername = new Label();
            lblpassword = new Label();
            lblnote = new Label();
            txtwebsite = new TextBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtnote = new TextBox();
            btnnew = new Button();
            btnedit = new Button();
            btndelete = new Button();
            btnsave = new Button();
            panel3 = new Panel();
            lblcheckwebsite = new Label();
            lblcheckusername = new Label();
            lblcheckpassword = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(lblexit);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 32);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // lblexit
            // 
            lblexit.AutoSize = true;
            lblexit.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblexit.Location = new Point(894, 4);
            lblexit.Name = "lblexit";
            lblexit.Size = new Size(22, 28);
            lblexit.TabIndex = 1;
            lblexit.Text = "x";
            lblexit.Click += lblexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 4);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 0;
            label1.Text = "Password Manager";
            label1.Click += label1_Click;
            // 
            // lv
            // 
            lv.AccessibleRole = AccessibleRole.None;
            lv.BackColor = Color.PowderBlue;
            lv.BorderStyle = BorderStyle.FixedSingle;
            lv.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lv.Cursor = Cursors.Hand;
            lv.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv.Location = new Point(0, 27);
            lv.Name = "lv";
            lv.Size = new Size(493, 556);
            lv.TabIndex = 1;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = View.Details;
            lv.MouseDoubleClick += lv_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Websites";
            columnHeader1.Width = 500;
            // 
            // lblname
            // 
            lblname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.DarkRed;
            lblname.Location = new Point(582, 176);
            lblname.Name = "lblname";
            lblname.Size = new Size(74, 25);
            lblname.TabIndex = 2;
            lblname.Text = "Website";
            // 
            // lblusername
            // 
            lblusername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.DarkRed;
            lblusername.Location = new Point(582, 247);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(90, 23);
            lblusername.TabIndex = 3;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.ForeColor = Color.DarkRed;
            lblpassword.Location = new Point(582, 312);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(90, 27);
            lblpassword.TabIndex = 4;
            lblpassword.Text = "Password";
            lblpassword.Click += label4_Click;
            // 
            // lblnote
            // 
            lblnote.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnote.ForeColor = Color.DarkRed;
            lblnote.Location = new Point(574, 384);
            lblnote.Name = "lblnote";
            lblnote.Size = new Size(98, 24);
            lblnote.TabIndex = 5;
            lblnote.Text = "Description";
            lblnote.Click += lblnote_Click;
            // 
            // txtwebsite
            // 
            txtwebsite.BackColor = Color.Linen;
            txtwebsite.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtwebsite.Location = new Point(689, 176);
            txtwebsite.Name = "txtwebsite";
            txtwebsite.Size = new Size(199, 26);
            txtwebsite.TabIndex = 6;
            txtwebsite.TextChanged += txtwebsite_TextChanged;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.Linen;
            txtusername.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(689, 244);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(199, 26);
            txtusername.TabIndex = 7;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.Linen;
            txtpassword.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(689, 309);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(199, 26);
            txtpassword.TabIndex = 8;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // txtnote
            // 
            txtnote.BackColor = Color.Linen;
            txtnote.BorderStyle = BorderStyle.FixedSingle;
            txtnote.Font = new Font("Sitka Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnote.Location = new Point(689, 384);
            txtnote.Multiline = true;
            txtnote.Name = "txtnote";
            txtnote.Size = new Size(199, 103);
            txtnote.TabIndex = 9;
            // 
            // btnnew
            // 
            btnnew.BackColor = Color.Pink;
            btnnew.FlatAppearance.BorderColor = Color.Orchid;
            btnnew.FlatAppearance.BorderSize = 3;
            btnnew.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnnew.FlatAppearance.MouseOverBackColor = Color.White;
            btnnew.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(537, 510);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(85, 29);
            btnnew.TabIndex = 10;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = false;
            btnnew.Click += btnnew_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Pink;
            btnedit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnedit.Location = new Point(719, 510);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(89, 29);
            btnedit.TabIndex = 11;
            btnedit.Text = "Update";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Pink;
            btndelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(628, 510);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(85, 29);
            btndelete.TabIndex = 12;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Pink;
            btnsave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(823, 510);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(82, 29);
            btnsave.TabIndex = 13;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(582, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 125);
            panel3.TabIndex = 15;
            // 
            // lblcheckwebsite
            // 
            lblcheckwebsite.AutoSize = true;
            lblcheckwebsite.ForeColor = Color.Red;
            lblcheckwebsite.Location = new Point(689, 205);
            lblcheckwebsite.Name = "lblcheckwebsite";
            lblcheckwebsite.Size = new Size(0, 20);
            lblcheckwebsite.TabIndex = 16;
            // 
            // lblcheckusername
            // 
            lblcheckusername.AutoSize = true;
            lblcheckusername.ForeColor = Color.Red;
            lblcheckusername.Location = new Point(689, 273);
            lblcheckusername.Name = "lblcheckusername";
            lblcheckusername.Size = new Size(0, 20);
            lblcheckusername.TabIndex = 17;
            // 
            // lblcheckpassword
            // 
            lblcheckpassword.AutoSize = true;
            lblcheckpassword.ForeColor = Color.Red;
            lblcheckpassword.Location = new Point(686, 342);
            lblcheckpassword.Name = "lblcheckpassword";
            lblcheckpassword.Size = new Size(0, 20);
            lblcheckpassword.TabIndex = 18;
            // 
            // internalform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(919, 583);
            Controls.Add(txtpassword);
            Controls.Add(lblcheckpassword);
            Controls.Add(lblcheckusername);
            Controls.Add(lblcheckwebsite);
            Controls.Add(panel3);
            Controls.Add(btnsave);
            Controls.Add(btndelete);
            Controls.Add(btnedit);
            Controls.Add(btnnew);
            Controls.Add(txtnote);
            Controls.Add(txtusername);
            Controls.Add(txtwebsite);
            Controls.Add(lblnote);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(lblname);
            Controls.Add(lv);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "internalform";
            Load += internalform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblexit;
        private Label label1;
        private ListView lv;
        private Label lblname;
        private Label lblusername;
        private Label lblpassword;
        private Label lblnote;
        private TextBox txtwebsite;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtnote;
        private Button btnnew;
        private Button btnedit;
        private Button btndelete;
        private Button btnsave;
        private ColumnHeader columnHeader1;
        private Panel panel3;
        private Label lblcheckwebsite;
        private Label lblcheckusername;
        private Label lblcheckpassword;
    }
}
