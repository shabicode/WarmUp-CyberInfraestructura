# WarmUp-CyberInfraestructura
Monica Andrea Abarca Martinez
<img width="326" height="338" alt="image" src="https://github.com/user-attachments/assets/8aef60d6-cb75-4232-95fe-40391b7ccb42" />

# Password Validator
Proyecto desarrollado para la materia **CiberInfraestructura**
Aplicación de escritorio en **C# Windows Forms** que valida contraseñas seguras mediante expresiones regulares.
---

## Descripción

El formulario solicita al usuario crear una contraseña que cumpla con los siguientes requisitos de seguridad:

- Al menos una **letra mayúscula**
- Al menos una **letra minúscula**
- Al menos un **número**
- Al menos un **símbolo** (!@#$%...)
- Ambas contraseñas deben **coincidir**

---

## Código Fuente

```csharp
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
```

---

##  Escenarios.

|  Contraseña Inválida |  Contraseñas no coinciden |  Contraseña Válida |
|----------------------|---------------------------|---------------------|
| <img width="230" height="168" alt="image" src="https://github.com/user-attachments/assets/64cc5d66-8089-4454-80df-15a00067f906" /> | <img width="253" height="157" alt="image" src="https://github.com/user-attachments/assets/365d9da3-23c2-4e2c-b3e8-cd76bbaaa194" /> | <img width="196" height="161" alt="image" src="https://github.com/user-attachments/assets/c020a5f3-cb31-4213-a561-cc7d4eb28d2e" /> |

