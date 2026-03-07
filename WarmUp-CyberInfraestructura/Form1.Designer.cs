namespace WarmUp_CyberInfraestructura
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
			txtPassword = new TextBox();
			txtPasswordConfirm = new TextBox();
			btnValidate = new Button();
			label1 = new Label();
			label2 = new Label();
			SuspendLayout();
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(221, 150);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(248, 23);
			txtPassword.TabIndex = 0;
			// 
			// txtPasswordConfirm
			// 
			txtPasswordConfirm.Location = new Point(221, 215);
			txtPasswordConfirm.Name = "txtPasswordConfirm";
			txtPasswordConfirm.Size = new Size(248, 23);
			txtPasswordConfirm.TabIndex = 1;
			// 
			// btnValidate
			// 
			btnValidate.Font = new Font("Yu Gothic UI Semibold", 9F);
			btnValidate.Location = new Point(274, 278);
			btnValidate.Name = "btnValidate";
			btnValidate.Size = new Size(123, 31);
			btnValidate.TabIndex = 2;
			btnValidate.Text = "Validate";
			btnValidate.UseVisualStyleBackColor = true;
			btnValidate.Click += btnValidate_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(101, 158);
			label1.Name = "label1";
			label1.Size = new Size(57, 15);
			label1.TabIndex = 3;
			label1.Text = "Password";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(81, 218);
			label2.Name = "label2";
			label2.Size = new Size(104, 15);
			label2.TabIndex = 3;
			label2.Text = "Confirm Password";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(648, 454);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnValidate);
			Controls.Add(txtPasswordConfirm);
			Controls.Add(txtPassword);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtPassword;
		private TextBox txtPasswordConfirm;
		private Button btnValidate;
		private Label label1;
		private Label label2;
	}
}
