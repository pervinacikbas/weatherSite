using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace weather
{
    public partial class FormLogIncs : Form
    {
        public FormLogIncs()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EQLPKL0\\SQLEXPRESS;Initial Catalog=havaDurumuDb;Integrated Security=True");
        private void FormLogIncs_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnterLog_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekleme = new SqlCommand("INSERT INTO Table_User (Name, Surname, Email, Password) VALUES (@Name,@Surname,@Email,@Password)", baglanti);
            ekleme.Parameters.AddWithValue("@Name", textBoxName.Text);
            ekleme.Parameters.AddWithValue("@Surname", textBoxSurname.Text);
            ekleme.Parameters.AddWithValue("@Email", textBoxEmailLog.Text);
            ekleme.Parameters.AddWithValue("@Password", textBoxPasswordLog.Text);

            ekleme.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
            MessageBox.Show("Sayın " +textBoxName.Text  +" kaydınız tamamlandı. ");

        }

        private void checkBoxPasswordShowLog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordShowLog.Checked == true)
                textBoxPasswordLog.UseSystemPasswordChar = false;
            else
                textBoxPasswordLog.UseSystemPasswordChar = true;
        }
    }
}
