using PlannerCommon;
using PlannerDataService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsAppDP
{
    public partial class Form2 : Form
    {
        private string email;
        private IPlannerDataService dataService;
      
        public Form2(string email, IPlannerDataService dataService)
        {
            InitializeComponent();
            this.email = email;
            this.dataService = dataService;
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());

            PlannerService.PlannerService plannerService = new PlannerService.PlannerService(email, firstName, lastName, age, dataService);

            Form3 plannerForm = new Form3(plannerService, dataService, firstName);
            this.Hide();
            plannerForm.ShowDialog();
            this.Close();
        }
        
        

        private bool ValidateUserDetails()
        {
           
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowError("Please enter first name", txtFirstName);
                return false;
            }

         
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowError("Please enter last name", txtLastName);
                return false;
            }

           
            if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 120)
            {
                ShowError("Please enter valid age (1-120)", txtAge);
                return false;
            }

            return true;
        }

        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
            if (control is TextBox) ((TextBox)control).SelectAll();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }
    }
}
