namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BotonAceptar_Click(object sender, EventArgs e)

        {
            string Nombre = TextNombre.Text.Trim();
            string Email = TextCorreo.Text.Trim();
            string Telefono = TextTelefono.Text.Trim();
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Telefono))
            {
                LabelConfirmacion.Text = "Por favor complete los campos.";
            }

            else
            {

                string contacto = $"{Nombre} - {Email} - {Telefono}";
                listBox1.Items.Add(contacto);
                LabelConfirmacion.Text = "Formulario enviado correctamente.";


            }
        }

        private void BotonLimpiarDirectorio_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TextNombre.Clear();
            TextCorreo.Clear();
            TextTelefono.Clear();
        }

        private void TextNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
