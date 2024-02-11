using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Datos_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string matricula = txt_Matricula.Text;
            string nombre = txt_Nombre.Text;
            string apellido = txt_Apellido.Text;
            int edad = int.Parse(txt_Edad.Text);
            string carrera = txt_Carrera.Text;

            txt_Datos.Text = $"Matrícula: {matricula} \nNombre: {nombre} \nApellido: {apellido} \nEdad: {edad} \nCarrera: {carrera}";

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

            txt_Matricula.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Edad.Clear();
            txt_Carrera.Clear();
            txt_Datos.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Matricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
