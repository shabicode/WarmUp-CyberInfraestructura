namespace WarmUp_CyberInfraestructura
{
	partial class frmPasswordValidator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasswordValidator));
			txtPassword = new TextBox();
			txtPasswordConfirm = new TextBox();
			btnValidate = new Button();
			label1 = new Label();
			label2 = new Label();
			panel1 = new Panel();
			lblTitle = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// txtPassword
			// 
			txtPassword.BackColor = Color.FromArgb(255, 249, 240);
			txtPassword.BorderStyle = BorderStyle.FixedSingle;
			txtPassword.Location = new Point(65, 95);
			txtPassword.MaxLength = 32769;
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(191, 23);
			txtPassword.TabIndex = 0;
			// 
			// txtPasswordConfirm
			// 
			txtPasswordConfirm.BackColor = Color.FromArgb(255, 249, 240);
			txtPasswordConfirm.BorderStyle = BorderStyle.FixedSingle;
			txtPasswordConfirm.Location = new Point(65, 160);
			txtPasswordConfirm.Name = "txtPasswordConfirm";
			txtPasswordConfirm.Size = new Size(191, 23);
			txtPasswordConfirm.TabIndex = 1;
			// 
			// btnValidate
			// 
			btnValidate.AutoSize = true;
			btnValidate.BackColor = Color.FromArgb(255, 179, 209);
			btnValidate.BackgroundImage = (Image)resources.GetObject("btnValidate.BackgroundImage");
			btnValidate.FlatAppearance.BorderSize = 0;
			btnValidate.FlatStyle = FlatStyle.Popup;
			btnValidate.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnValidate.ForeColor = Color.DarkSlateBlue;
			btnValidate.Location = new Point(65, 200);
			btnValidate.Name = "btnValidate";
			btnValidate.Size = new Size(191, 47);
			btnValidate.TabIndex = 2;
			btnValidate.Text = " 🌸 Validate 🌸";
			btnValidate.UseVisualStyleBackColor = false;
			btnValidate.Click += btnValidate_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold);
			label1.ForeColor = Color.DarkSlateBlue;
			label1.Location = new Point(65, 75);
			label1.Name = "label1";
			label1.Size = new Size(115, 17);
			label1.TabIndex = 3;
			label1.Text = "Password 💜✨";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold);
			label2.ForeColor = Color.DarkSlateBlue;
			label2.Location = new Point(65, 140);
			label2.Name = "label2";
			label2.Size = new Size(154, 17);
			label2.TabIndex = 3;
			label2.Text = "Confirm Password ✨";
			// 
			// panel1
			// 
			panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
			panel1.Controls.Add(lblTitle);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(429, 32);
			panel1.TabIndex = 4;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.BackColor = Color.Transparent;
			lblTitle.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.Indigo;
			lblTitle.Location = new Point(80, 9);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(139, 17);
			lblTitle.TabIndex = 5;
			lblTitle.Text = "Password Validator";
			// 
			// frmPasswordValidator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LavenderBlush;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(319, 322);
			Controls.Add(panel1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnValidate);
			Controls.Add(txtPasswordConfirm);
			Controls.Add(txtPassword);
			FormBorderStyle = FormBorderStyle.None;
			Name = "frmPasswordValidator";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Password Validator";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtPassword;
		private TextBox txtPasswordConfirm;
		private Button btnValidate;
		private Label label1;
		private Label label2;
		private Panel panel1;
		private Label lblTitle;
	}
}
