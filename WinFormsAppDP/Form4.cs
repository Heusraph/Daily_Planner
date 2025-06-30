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
    public partial class Form4 : Form
    {
        public string PlanDescription { get; private set; }
        public DateTime PlanTime { get; private set; }
        public Form4(string description = "", DateTime? time = null)
        {
            InitializeComponent();

            txtDescription.Text = description;
            dtpTime.Value = time ?? DateTime.Now;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            PlanDescription = txtDescription.Text.Trim();
            PlanTime = dtpTime.Value;
            return true;
        }
    }
}
