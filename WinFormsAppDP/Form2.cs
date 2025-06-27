using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (ValidateUserDetails())
            {
                try
                {
                    Form3 mainPlanner = new Form3(
                        txtFirstName.Text.Trim(),
                        txtLastName.Text.Trim(),
                        int.Parse(txtAge.Text));

                    this.Hide();
                    mainPlanner.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private bool ValidateUserDetails()
        {
            // First Name validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowError("Please enter first name", txtFirstName);
                return false;
            }

            // Last Name validation
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowError("Please enter last name", txtLastName);
                return false;
            }

            // Age validation
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
