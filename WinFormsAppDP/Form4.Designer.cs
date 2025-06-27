namespace WinFormsAppDP
{
    partial class Form4
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
            btnOk = new Button();
            btnCancel = new Button();
            txtDescription = new TextBox();
            dtpTime = new DateTimePicker();
            lblDesc = new Label();
            lblTime = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.BackColor = SystemColors.ControlLightLight;
            btnOk.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(90, 248);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "OKAY";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLightLight;
            btnCancel.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(183, 248);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(77, 155);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 25);
            txtDescription.TabIndex = 2;
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(78, 215);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(107, 23);
            dtpTime.TabIndex = 3;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(77, 127);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(171, 23);
            lblDesc.TabIndex = 4;
            lblDesc.Text = "Plan with purpose";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(77, 189);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(46, 20);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time";
            // 
            // Form4
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.dpteacher6;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = btnCancel;
            ClientSize = new Size(350, 331);
            Controls.Add(lblTime);
            Controls.Add(lblDesc);
            Controls.Add(dtpTime);
            Controls.Add(txtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancel;
        private TextBox txtDescription;
        private DateTimePicker dtpTime;
        private Label lblDesc;
        private Label lblTime;
    }
}