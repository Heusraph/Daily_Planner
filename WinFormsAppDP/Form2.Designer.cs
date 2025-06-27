namespace WinFormsAppDP
{
    partial class Form2
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAge = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            btnContinue = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Ink Free", 29.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(29, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(376, 50);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "LET'S SET YOU UP";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(52, 147);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(98, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(52, 189);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(98, 24);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblAge
            // 
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(52, 226);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(45, 23);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            lblAge.Click += label4_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(148, 147);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(194, 25);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(148, 188);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(194, 25);
            txtLastName.TabIndex = 5;
            txtLastName.TextChanged += textBox2_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(148, 226);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(194, 25);
            txtAge.TabIndex = 6;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = SystemColors.ControlLightLight;
            btnContinue.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(169, 274);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(92, 30);
            btnContinue.TabIndex = 7;
            btnContinue.Text = "CONTINUE";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = Properties.Resources.dpraven;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(427, 350);
            Controls.Add(btnContinue);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblAge);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblWelcome);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAge;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private Button btnContinue;
    }
}