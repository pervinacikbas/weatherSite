using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace weather
{
    public partial class FormSingIn : Form
    {

        public FormSingIn()
        {
            InitializeComponent();

        }
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-EQLPKL0\\SQLEXPRESS;Initial Catalog=havaDurumuDb;Integrated Security=True");
        private void FormSingIn_Load(object sender, EventArgs e)
        {

        }

        public void buttonEnter_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            using (SqlConnection baglantiyiac = new SqlConnection("Data Source=DESKTOP-EQLPKL0\\SQLEXPRESS;Initial Catalog=havaDurumuDb;Integrated Security=True"))
            {
                //baglantiyiac.OpenAsync();
                string email = Convert.ToString(textBoxEmailSing.Text).ToUpper();
                string password = Convert.ToString(textBoxPasswordSing.Text);

                using (SqlCommand emailChack = new SqlCommand("SELECT COUNT(*) FROM Table_User WHERE email = @email", baglanti))
                {
                    emailChack.Parameters.AddWithValue("@email", email);

                    int emailCount = (int)emailChack.ExecuteScalar();
                    if (emailCount == 0)
                        MessageBox.Show("Bu maile kayıtlı kullanıcı bulunamadı.");
                }

                using (SqlCommand giris = new SqlCommand("SELECT COUNT(*) FROM Table_User WHERE email = @email AND password = @password", baglanti))
                {
                    giris.Parameters.AddWithValue("@email", email);
                    giris.Parameters.AddWithValue("@password", password);

                    int girisCount = (int)giris.ExecuteScalar();
                    if (girisCount == 0)
                        MessageBox.Show("Yanlış mail ve ya şifre");
                    else
                    {
                        Form1 form = new Form1();
                        form.ShowDialog();
                        this.Close();
                    }
                }
            }



            /*baglanti.Open();
            string email = Convert.ToString(textBoxEmailSing.Text).ToUpper();
            string password = Convert.ToString(textBoxPasswordSing.Text);

            SqlCommand emailChack = new SqlCommand("SELECT COUNT(*) FROM Table_User WHERE email = @email", baglanti);
            emailChack.Parameters.AddWithValue("@email", email);

            SqlCommand giris = new SqlCommand("SELECT COUNT(*) FROM Table_User WHERE email = @email AND password = @password", baglanti);
            giris.Parameters.AddWithValue("email", email);
            giris.Parameters.AddWithValue("password", password);

            int emailCount = (int)emailChack.ExecuteScalar();
            if (emailCount == 0)
                MessageBox.Show("Bu maile kayıtlı kullanıcı bulunamadı.");
            int girisCount = (int)giris.ExecuteScalar();
            if (girisCount == 0)
                MessageBox.Show("Yanlış mail ve ya şifre ");
            else
            {
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }*/


        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (true)
            {
                FormLogIncs formLogIncs = new FormLogIncs();
                formLogIncs.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand listele = new SqlCommand();
            listele.CommandText = "Select * FROM Table_User ";


            listele.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(listele);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);


            for (int i = 0; i < tablo.Rows.Count; i++)
            {
                listView1.Items.Add(tablo.Rows[i]["Name"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Surname"].ToString());
                listView1.Items[i].SubItems.Add(tablo.Rows[i]["Email"].ToString());
            }

        }

        private void checkBoxPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordShow.Checked == true)
                textBoxPasswordSing.UseSystemPasswordChar = false;
            else
                textBoxPasswordSing.UseSystemPasswordChar = true;

        }
    }
}
