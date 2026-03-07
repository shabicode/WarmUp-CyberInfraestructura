using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WarmUp_CyberInfraestructura
{
	public partial class Form1 : Form
	{
		private Regex PasswordRegex = new Regex(
		@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$",
		RegexOptions.Compiled
		);

		public Form1()
		{
			InitializeComponent();
		}

		private void btnValidate_Click(object sender, EventArgs e)
		{
			if (!PasswordRegex.IsMatch(txtPassword.Text))
			{
				MessageBox.Show("Contrasena Invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (txtPassword.Text != txtPasswordConfirm.Text)
			{
				MessageBox.Show("Las contrasenas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show("Contrasena Valida", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
