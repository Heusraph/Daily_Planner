namespace WinFormsAppDP
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            labelyourplans = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnlogout = new Button();
            lvPlans = new ListView();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Ink Free", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(129, 65);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(231, 53);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hello, (User)";
            // 
            // labelyourplans
            // 
            labelyourplans.BackColor = Color.Transparent;
            labelyourplans.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelyourplans.Location = new Point(63, 133);
            labelyourplans.Name = "labelyourplans";
            labelyourplans.Size = new Size(182, 38);
            labelyourplans.TabIndex = 1;
            labelyourplans.Text = "Today's Schedule";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLightLight;
            btnAdd.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(63, 363);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Plan";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLightLight;
            btnUpdate.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(166, 363);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 28);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update Plan";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.ControlLightLight;
            btnRemove.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(287, 363);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(122, 28);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove Plan";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = SystemColors.ControlLightLight;
            btnlogout.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(339, 410);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(106, 28);
            btnlogout.TabIndex = 6;
            btnlogout.Text = "Log out";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += button1_Click_1;
            // 
            // lvPlans
            // 
            lvPlans.Font = new Font("Ink Free", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lvPlans.Location = new Point(63, 174);
            lvPlans.Name = "lvPlans";
            lvPlans.Size = new Size(351, 168);
            lvPlans.TabIndex = 7;
            lvPlans.UseCompatibleStateImageBehavior = false;
            lvPlans.SelectedIndexChanged += lvPlans_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dpteacher5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(467, 450);
            Controls.Add(lvPlans);
            Controls.Add(btnlogout);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(labelyourplans);
            Controls.Add(lblWelcome);
            DoubleBuffered = true;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Label labelyourplans;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnlogout;
        private ListView lvPlans;
    }
}