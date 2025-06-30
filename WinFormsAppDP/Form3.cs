using PlannerCommon;
using PlannerDataService;
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
using PlannerService;
namespace WinFormsAppDP
{
    public partial class Form3 : Form
    {
        private PlannerService.PlannerService plannerService;
        private IPlannerDataService dataService;
        public Form3(PlannerService.PlannerService plannerService, IPlannerDataService dataService, string firstName)
        {   

            InitializeComponent();
            this. plannerService = plannerService;
            this.dataService = dataService;
     
            lblWelcome.Text = $"Hello, {firstName}";  
            SetupPlansTable();
            RefreshPlansList();
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

            foreach (var plan in plannerService.GetPlans())
            {
                var item = new ListViewItem();
                item.SubItems.Add(plan.Description);
                item.SubItems.Add(plan.Time);
                item.Tag = plan;
                lvPlans.Items.Add(item);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var inputForm = new Form4())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    plannerService.AddPlan(inputForm.PlanDescription, inputForm.PlanTime.ToString("hh:mm tt"));
                    RefreshPlansList();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lvPlans.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a plan to update");
                return;
            }

            int index = lvPlans.SelectedIndices[0];
            var selected = plannerService.GetPlans()[index];

            using (var inputForm = new Form4(selected.Description, DateTime.Parse(selected.Time)))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    plannerService.UpdatePlan(index, inputForm.PlanDescription, inputForm.PlanTime.ToString("hh:mm tt"));

                    RefreshPlansList();
                }
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

            plannerService.RemovePlan(lvPlans.SelectedIndices[0]);
            RefreshPlansList();
        }
    }
}
