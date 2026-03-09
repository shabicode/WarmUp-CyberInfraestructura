using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WarmUp_CyberInfraestructura
{
	public partial class frmPasswordValidator : Form
	{
		// Expresión regular que valida que la contraseña tenga:
		// mayúscula, minúscula, número y símbolo
		[GeneratedRegex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+$", RegexOptions.Compiled)]
		private static partial Regex PasswordValidationRegex();

		// Creamos el objeto regex para usarlo en la validación
		private Regex PasswordRegex = PasswordValidationRegex();

		public frmPasswordValidator()
		{
			InitializeComponent();
		}

		// Funcion para validar la contraseña al hacer clic en el botón
		private void btnValidate_Click(object sender, EventArgs e)
		{
			// Verifica que la contraseña cumpla con el formato requerido usando la expresión regular
			if (!PasswordRegex.IsMatch(txtPassword.Text))
			{
				// Si no cumple, mostramos un mensaje de error y salimos
				MessageBox.Show("Contrasena Invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Verificamos que ambas contraseñas sean iguales
			if (txtPassword.Text != txtPasswordConfirm.Text)
			{
				// Si no coinciden, mostramos error y salimos
				MessageBox.Show("Las contrasenas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Si pasó ambas validaciones, la contraseña es válida
			MessageBox.Show("Contrasena Valida", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


	}
}
