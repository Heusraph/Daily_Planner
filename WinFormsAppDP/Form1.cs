using PlannerDataService;
using System.Media;

namespace WinFormsAppDP
{
    public partial class Form1 : Form
    {
        private IPlannerDataService dataService;
        public Form1(IPlannerDataService dataService)
        {

            InitializeComponent();
            this.dataService = dataService;

            var profiles = dataService.GetProfiles();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (ValidateEmail(txtEmail.Text))
            {
                var soundBytes = Properties.Resources.sharingan;
                using (var stream = new System.IO.MemoryStream(soundBytes))
                {
                    new SoundPlayer(stream).Play();
                }
                
                var setupForm = new Form2(email, dataService);
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
            var profiles = dataService.GetProfiles();
            if (profiles.Any())
                MessageBox.Show("First profile: " + profiles[0].FirstName);
            else
                MessageBox.Show("no profiles");
        }
    }
}
