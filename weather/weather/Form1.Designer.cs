namespace weather
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
            button1 = new Button();
            labelTemperature = new Label();
            labelCity = new Label();
            konum = new TextBox();
            labelWind = new Label();
            labelTarih = new Label();
            labelHavaDurumu = new Label();
            labelHissedilen = new Label();
            Iconbox = new PictureBox();
            listBoxKonum = new ListBox();
            buttonKaydedici = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Iconbox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(149, 610);
            button1.Name = "button1";
            button1.Size = new Size(192, 47);
            button1.TabIndex = 2;
            button1.Text = "Konumu bul";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelTemperature
            // 
            labelTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTemperature.AutoSize = true;
            labelTemperature.BackColor = Color.Transparent;
            labelTemperature.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemperature.Location = new Point(910, 47);
            labelTemperature.MinimumSize = new Size(100, 40);
            labelTemperature.Name = "labelTemperature";
            labelTemperature.Size = new Size(100, 40);
            labelTemperature.TabIndex = 4;
            labelTemperature.Text = "Derece";
            labelTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.BackColor = Color.Transparent;
            labelCity.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCity.Location = new Point(128, 38);
            labelCity.MinimumSize = new Size(100, 40);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(100, 40);
            labelCity.TabIndex = 5;
            labelCity.Text = "Konum";
            labelCity.TextAlign = ContentAlignment.MiddleCenter;
            labelCity.Click += labelCity_Click;
            // 
            // konum
            // 
            konum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            konum.Location = new Point(61, 530);
            konum.Multiline = true;
            konum.Name = "konum";
            konum.PlaceholderText = "Konum girin:";
            konum.Size = new Size(280, 32);
            konum.TabIndex = 6;
            konum.Tag = "";
            // 
            // labelWind
            // 
            labelWind.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelWind.AutoSize = true;
            labelWind.BackColor = Color.Transparent;
            labelWind.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWind.Location = new Point(920, 193);
            labelWind.MinimumSize = new Size(100, 30);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(100, 33);
            labelWind.TabIndex = 7;
            labelWind.Text = "Rüzgar";
            labelWind.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTarih
            // 
            labelTarih.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTarih.AutoSize = true;
            labelTarih.BackColor = Color.Transparent;
            labelTarih.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTarih.Location = new Point(128, 225);
            labelTarih.MinimumSize = new Size(100, 40);
            labelTarih.Name = "labelTarih";
            labelTarih.Size = new Size(100, 40);
            labelTarih.TabIndex = 8;
            labelTarih.Text = "Tarih";
            labelTarih.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHavaDurumu
            // 
            labelHavaDurumu.AutoSize = true;
            labelHavaDurumu.BackColor = Color.Transparent;
            labelHavaDurumu.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelHavaDurumu.Location = new Point(128, 112);
            labelHavaDurumu.MinimumSize = new Size(100, 40);
            labelHavaDurumu.Name = "labelHavaDurumu";
            labelHavaDurumu.Size = new Size(100, 40);
            labelHavaDurumu.TabIndex = 12;
            labelHavaDurumu.Text = "Durum";
            labelHavaDurumu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHissedilen
            // 
            labelHissedilen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelHissedilen.AutoSize = true;
            labelHissedilen.BackColor = Color.Transparent;
            labelHissedilen.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelHissedilen.Location = new Point(910, 112);
            labelHissedilen.MinimumSize = new Size(100, 40);
            labelHissedilen.Name = "labelHissedilen";
            labelHissedilen.Size = new Size(216, 40);
            labelHissedilen.TabIndex = 13;
            labelHissedilen.Text = "Hissedilen Derece";
            labelHissedilen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Iconbox
            // 
            Iconbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Iconbox.BackColor = Color.Transparent;
            Iconbox.Location = new Point(559, 67);
            Iconbox.Name = "Iconbox";
            Iconbox.Size = new Size(184, 235);
            Iconbox.SizeMode = PictureBoxSizeMode.StretchImage;
            Iconbox.TabIndex = 14;
            Iconbox.TabStop = false;
            // 
            // listBoxKonum
            // 
            listBoxKonum.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxKonum.BackColor = Color.LightGray;
            listBoxKonum.FormattingEnabled = true;
            listBoxKonum.ItemHeight = 20;
            listBoxKonum.Location = new Point(920, 541);
            listBoxKonum.Name = "listBoxKonum";
            listBoxKonum.Size = new Size(242, 144);
            listBoxKonum.TabIndex = 15;
            listBoxKonum.SelectedIndexChanged += listBoxKonum_SelectedIndexChanged;
            // 
            // buttonKaydedici
            // 
            buttonKaydedici.Anchor = AnchorStyles.Left;
            buttonKaydedici.BackColor = Color.Transparent;
            buttonKaydedici.BackgroundImage = Properties.Resources.Hnet1;
            buttonKaydedici.BackgroundImageLayout = ImageLayout.Center;
            buttonKaydedici.Location = new Point(485, 541);
            buttonKaydedici.Name = "buttonKaydedici";
            buttonKaydedici.Size = new Size(63, 60);
            buttonKaydedici.TabIndex = 16;
            buttonKaydedici.Text = "\r\n\r\n";
            buttonKaydedici.UseVisualStyleBackColor = false;
            buttonKaydedici.Click += buttonKaydedici_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(468, 617);
            button2.Name = "button2";
            button2.Size = new Size(110, 32);
            button2.TabIndex = 17;
            button2.Text = "Durdur\r\n\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1204982336_170667a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 697);
            Controls.Add(button2);
            Controls.Add(buttonKaydedici);
            Controls.Add(labelCity);
            Controls.Add(labelHavaDurumu);
            Controls.Add(listBoxKonum);
            Controls.Add(labelTarih);
            Controls.Add(Iconbox);
            Controls.Add(labelHissedilen);
            Controls.Add(labelWind);
            Controls.Add(konum);
            Controls.Add(labelTemperature);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Şehir";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Iconbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label labelTemperature;
        private Label labelCity;
        private TextBox konum;
        private Label labelWind;
        private Label labelTarih;
        private Label labelHavaDurumu;
        private Label labelHissedilen;
        private PictureBox Iconbox;
        private ListBox listBoxKonum;
        private Button buttonKaydedici;
        private Button button2;
    }
}