namespace weather
{
    partial class FormLogIncs
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
            buttonEnterLog = new Button();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            checkBoxPasswordShowLog = new CheckBox();
            textBoxPasswordLog = new TextBox();
            textBoxEmailLog = new TextBox();
            pictureBoxLogoLog = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoLog).BeginInit();
            SuspendLayout();
            // 
            // buttonEnterLog
            // 
            buttonEnterLog.Anchor = AnchorStyles.Bottom;
            buttonEnterLog.BackColor = Color.Tan;
            buttonEnterLog.Location = new Point(307, 354);
            buttonEnterLog.Name = "buttonEnterLog";
            buttonEnterLog.Size = new Size(170, 30);
            buttonEnterLog.TabIndex = 28;
            buttonEnterLog.Text = "Üye Ol";
            buttonEnterLog.UseVisualStyleBackColor = false;
            buttonEnterLog.Click += buttonEnterLog_Click;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSurname.BackColor = Color.Silver;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(368, 196);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(220, 30);
            textBoxSurname.TabIndex = 27;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxName.BackColor = Color.Silver;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(368, 143);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(220, 30);
            textBoxName.TabIndex = 26;
            // 
            // checkBoxPasswordShowLog
            // 
            checkBoxPasswordShowLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxPasswordShowLog.AutoSize = true;
            checkBoxPasswordShowLog.Location = new Point(636, 300);
            checkBoxPasswordShowLog.Name = "checkBoxPasswordShowLog";
            checkBoxPasswordShowLog.Size = new Size(118, 24);
            checkBoxPasswordShowLog.TabIndex = 23;
            checkBoxPasswordShowLog.Text = "Şifreyi göster";
            checkBoxPasswordShowLog.UseVisualStyleBackColor = true;
            checkBoxPasswordShowLog.CheckedChanged += checkBoxPasswordShowLog_CheckedChanged;
            // 
            // textBoxPasswordLog
            // 
            textBoxPasswordLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPasswordLog.BackColor = Color.Silver;
            textBoxPasswordLog.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswordLog.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordLog.Location = new Point(368, 297);
            textBoxPasswordLog.Name = "textBoxPasswordLog";
            textBoxPasswordLog.Size = new Size(220, 30);
            textBoxPasswordLog.TabIndex = 22;
            textBoxPasswordLog.UseSystemPasswordChar = true;
            // 
            // textBoxEmailLog
            // 
            textBoxEmailLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxEmailLog.BackColor = Color.Silver;
            textBoxEmailLog.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmailLog.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailLog.Location = new Point(368, 244);
            textBoxEmailLog.Name = "textBoxEmailLog";
            textBoxEmailLog.PlaceholderText = "example@gmail.com";
            textBoxEmailLog.Size = new Size(220, 30);
            textBoxEmailLog.TabIndex = 21;
            // 
            // pictureBoxLogoLog
            // 
            pictureBoxLogoLog.BackColor = Color.Transparent;
            pictureBoxLogoLog.BackgroundImage = Properties.Resources.Webp_net_resizeimage;
            pictureBoxLogoLog.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxLogoLog.Location = new Point(46, 66);
            pictureBoxLogoLog.Name = "pictureBoxLogoLog";
            pictureBoxLogoLog.Size = new Size(167, 160);
            pictureBoxLogoLog.TabIndex = 17;
            pictureBoxLogoLog.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(307, 77);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 29;
            label1.Text = "Hesap Oluşturun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(232, 143);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 30;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(232, 193);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 31;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(232, 244);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 32;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(232, 294);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 33;
            label5.Text = "Password";
            // 
            // FormLogIncs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEnterLog);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(checkBoxPasswordShowLog);
            Controls.Add(textBoxPasswordLog);
            Controls.Add(textBoxEmailLog);
            Controls.Add(pictureBoxLogoLog);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogIncs";
            Text = "FormLogIncs";
            Load += FormLogIncs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnterLog;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private CheckBox checkBoxPasswordShowLog;
        private TextBox textBoxPasswordLog;
        private TextBox textBoxEmailLog;
        private PictureBox pictureBoxLogoLog;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}