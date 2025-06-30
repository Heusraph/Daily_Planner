namespace WinFormsAppDP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcome = new Label();
            btnCreate = new Button();
            txtEmail = new TextBox();
            email = new Label();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Ink Free", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            welcome.Location = new Point(42, 36);
            welcome.Name = "welcome";
            welcome.Size = new Size(432, 38);
            welcome.TabIndex = 0;
            welcome.Text = "WELCOME TO DAILY PLANNER";
            welcome.Click += label1_Click;
            // 
            // btnCreate
            // 
            btnCreate.AccessibleRole = AccessibleRole.None;
            btnCreate.BackColor = SystemColors.ControlLightLight;
            btnCreate.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(200, 227);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(118, 41);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(172, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 25);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // email
            // 
            email.BackColor = SystemColors.ControlLightLight;
            email.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Black;
            email.Location = new Point(105, 189);
            email.Name = "email";
            email.Size = new Size(61, 19);
            email.TabIndex = 3;
            email.Text = "Email:";
            email.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dpt1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(504, 391);
            Controls.Add(email);
            Controls.Add(txtEmail);
            Controls.Add(btnCreate);
            Controls.Add(welcome);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Button btnCreate;
        private TextBox txtEmail;
        private Label email;
    }
}
