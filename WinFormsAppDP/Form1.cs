using PlannerDataService;
using System.Media;

namespace WinFormsAppDP
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateEmail(txtEmail.Text))
            {
                var soundBytes = Properties.Resources.sharingan;
                using (var stream = new System.IO.MemoryStream(soundBytes))
                {
                    new System.Media.SoundPlayer(stream).Play();
                }
                Form2 setupForm = new Form2();
                this.Hide();
                setupForm.ShowDialog();
                this.Close();
            }

          
        }
        private bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
