namespace weather
{
    partial class FormSingIn
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
            pictureBoxLogo = new PictureBox();
            textBoxEmailSing = new TextBox();
            textBoxPasswordSing = new TextBox();
            checkBoxPasswordShow = new CheckBox();
            buttonEnter = new Button();
            buttonLogIn = new Button();
            textBox6 = new TextBox();
            listView1 = new ListView();
            columnName = new ColumnHeader();
            columnSurname = new ColumnHeader();
            columnEmail = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.BackgroundImage = Properties.Resources.Webp_net_resizeimage;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxLogo.Location = new Point(123, 57);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(130, 113);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // textBoxEmailSing
            // 
            textBoxEmailSing.Anchor = AnchorStyles.None;
            textBoxEmailSing.BackColor = Color.Silver;
            textBoxEmailSing.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmailSing.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailSing.Location = new Point(337, 195);
            textBoxEmailSing.Name = "textBoxEmailSing";
            textBoxEmailSing.PlaceholderText = "example@gmail.com";
            textBoxEmailSing.Size = new Size(220, 30);
            textBoxEmailSing.TabIndex = 4;
            // 
            // textBoxPasswordSing
            // 
            textBoxPasswordSing.Anchor = AnchorStyles.None;
            textBoxPasswordSing.BackColor = Color.Silver;
            textBoxPasswordSing.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswordSing.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordSing.Location = new Point(337, 258);
            textBoxPasswordSing.Name = "textBoxPasswordSing";
            textBoxPasswordSing.Size = new Size(220, 30);
            textBoxPasswordSing.TabIndex = 5;
            textBoxPasswordSing.UseSystemPasswordChar = true;
            // 
            // checkBoxPasswordShow
            // 
            checkBoxPasswordShow.Anchor = AnchorStyles.None;
            checkBoxPasswordShow.AutoSize = true;
            checkBoxPasswordShow.Location = new Point(617, 266);
            checkBoxPasswordShow.Name = "checkBoxPasswordShow";
            checkBoxPasswordShow.Size = new Size(118, 24);
            checkBoxPasswordShow.TabIndex = 6;
            checkBoxPasswordShow.Text = "Şifreyi göster";
            checkBoxPasswordShow.UseVisualStyleBackColor = true;
            checkBoxPasswordShow.CheckedChanged += checkBoxPasswordShow_CheckedChanged;
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.None;
            buttonEnter.BackColor = Color.Tan;
            buttonEnter.Location = new Point(354, 294);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(170, 30);
            buttonEnter.TabIndex = 7;
            buttonEnter.Text = "Giriş";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.None;
            buttonLogIn.BackColor = Color.Tan;
            buttonLogIn.Location = new Point(337, 470);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(170, 30);
            buttonLogIn.TabIndex = 8;
            buttonLogIn.Text = "Üye Ol";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BackColor = SystemColors.ControlDarkDark;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(337, 435);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(398, 20);
            textBox6.TabIndex = 9;
            textBox6.Text = "Üye değilseniz üye olmak için Üye O\r\nl tuşuna basın";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnSurname, columnEmail });
            listView1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(787, 331);
            listView1.Name = "listView1";
            listView1.Size = new Size(242, 198);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnName
            // 
            columnName.Text = "Name";
            // 
            // columnSurname
            // 
            columnSurname.Text = "Surname";
            // 
            // columnEmail
            // 
            columnEmail.Text = "E-mail";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(899, 286);
            button1.Name = "button1";
            button1.Size = new Size(117, 46);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 83);
            label1.Name = "label1";
            label1.Size = new Size(484, 41);
            label1.TabIndex = 12;
            label1.Text = "Hava Durumu Sitesine Hoş Geldiniz";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(195, 195);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 13;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(195, 260);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 14;
            label3.Text = "Password";
            // 
            // FormSingIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1028, 526);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(textBox6);
            Controls.Add(buttonLogIn);
            Controls.Add(buttonEnter);
            Controls.Add(checkBoxPasswordShow);
            Controls.Add(textBoxPasswordSing);
            Controls.Add(textBoxEmailSing);
            Controls.Add(pictureBoxLogo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSingIn";
            Text = "FormSingIn";
            Load += FormSingIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private TextBox textBoxEmailSing;
        private TextBox textBoxPasswordSing;
        private CheckBox checkBoxPasswordShow;
        private Button buttonEnter;
        private Button buttonLogIn;
        private TextBox textBox6;
        private ListView listView1;
        private Button button1;
        private ColumnHeader columnName;
        private ColumnHeader columnSurname;
        private ColumnHeader columnEmail;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}