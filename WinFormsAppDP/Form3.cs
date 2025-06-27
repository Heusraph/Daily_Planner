using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDP
{
    public partial class Form3 : Form
    {
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly int _age;
        private List<Plan> plans = new List<Plan>();
        public Form3(string firstName, string lastName, int age)
        {
            InitializeComponent();

            _firstName = firstName;
            _lastName = lastName;
            _age = age;

            lblWelcome.Text = $"Hello, {firstName}";
            SetupPlansTable();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupPlansTable()
        {
            lvPlans.Columns.Clear();

            lvPlans.Columns.Add("", 30);
            lvPlans.Columns.Add("Plans", 200);
            lvPlans.Columns.Add("Time", 100);

            lvPlans.View = View.Details;
            lvPlans.FullRowSelect = true;
            lvPlans.MultiSelect = false;
        }
        private void RefreshPlansList()
        {
            lvPlans.Items.Clear();

            foreach (var plan in plans)
            {
                var item = new ListViewItem(); 
                item.SubItems.Add(plan.Description);
                item.SubItems.Add(plan.Time.ToString("hh:mm tt"));
                item.Tag = plan;
                lvPlans.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var inputForm = new Form4())
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                plans.Add(new Plan
                {
                    Description = inputForm.PlanDescription,
                    Time = inputForm.PlanTime
                }); 
                RefreshPlansList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lvPlans.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a plan to update");
                return;
            }

            int selectedIndex = lvPlans.SelectedIndices[0];
            var selectedPlan = plans[selectedIndex];

            var inputForm = new Form4(selectedPlan.Description, selectedPlan.Time);
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                selectedPlan.Description = inputForm.PlanDescription;
                selectedPlan.Time = inputForm.PlanTime;
                RefreshPlansList();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void lvPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvPlans.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a plan to remove");
                return;
            }

            int selectedIndex = lvPlans.SelectedIndices[0];
            plans.RemoveAt(selectedIndex);
            RefreshPlansList();
        }
    }
}
