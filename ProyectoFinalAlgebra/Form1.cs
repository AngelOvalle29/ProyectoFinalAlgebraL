using System;
using QRCoder;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Controls;


namespace ProyectoFinalAlgebra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string codigo;
        }
        private void SwitchLimpiar_Click(object sender, EventArgs e)
        {
            //Instrucciones para el botón de limpiar los datos tanto de los textBox como del PictureBox del QR
            TextBoxCarnet.Text = "";
            TextBoxResultado.Text = "";
            QR.Image = null;
        }

        private void PropiedadesCodigoQR(string texto)
        {
            //Codigo el cual habilita la opción de generar un Qr para la compilación
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            // Instrucción para el tamaño del QR
            QR.Image = qrCode.GetGraphic(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxResultado.Visible = false;
            label2.Visible = false;
        }
        private string NuevoCarnet(string NewLicense)
        {
            //Declaración de la matriz la cual hace referencia al Z11
            int[] Z11 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //Condición la cual evalúa el caso de que el usuario no ingrese la cantidad necesaria de dígitos
            if (NewLicense.Length != 9)
            {
                MessageBox.Show("Favor de ingresar la cantidad exacta de 9 dígitos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            //Instrucción que genera los valores del carnet nuevo y que evalúa que solo contenga dígitos la cadena 
            int[] digitos = new int[9];
            for (int i = 0; i < 9; i++)
            {
                if (!int.TryParse(NewLicense[i].ToString(), out digitos[i]))
                {
                    MessageBox.Show("El carnet solo admite datos numéricos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return "";
                }
            }
            //Procedimiento matemático para generar el último carácter el cual es el de verificación
            int suma = 0;
            for (int i = 0; i < 9; i++)
            {
                suma += digitos[i] * Z11[i];
            }

            int Verificacion = (11 - (suma % 11)) % 11;

            // Instrucción con el fin de ocultar el último dígito de el carnet
            char letradeVerificacion = (char)(42); // Conversión del Número obtenido a una letra mayúscula
            return NewLicense + letradeVerificacion;
        }
        private void GuardarDatos(string carneNuevo )
        {
            // Función e instrucciones las cuales estipulan la dirección a donde serán guardados los datos
            // Y genera el archivo .txt el cual contendrá todos los carnets ingresados
            string direccionArchivo = "Datos.txt";
            using (StreamWriter sw = File.AppendText(direccionArchivo)) // Hace que no se sobre escriba el contenido
            {
                sw.WriteLine(carneNuevo);
            }
        }
        private void SwitchGuardar_Click(object sender, EventArgs e)
        {
            //Botón con la funcionalidad de guardar los carnets en el archivo .txt
            string NuevoCarnet = TextBoxResultado.Text;
            if (!string.IsNullOrEmpty(NuevoCarnet))
            {
                GuardarDatos(NuevoCarnet);
                MessageBox.Show("El carnet generado se ha guardado con éxito!!!", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No existe algún carnet el cual se pueda guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SwitchGenerar_Click(object sender, EventArgs e)
        {
            string codigo;
            //Botón el cual genera el nuevo carnet y el QR
            TextBoxResultado.Visible = true;
            label2.Visible = true;
            string carneActual = TextBoxCarnet.Text;
            string nuevoCarne = NuevoCarnet(carneActual);
            TextBoxResultado.Text = nuevoCarne;
            if (nuevoCarne.Contains("2023")||nuevoCarne.Contains("2022") || nuevoCarne.Contains("2021") || nuevoCarne.Contains("2020") || nuevoCarne.Contains("2019") || nuevoCarne.Contains("2018") || nuevoCarne.Contains("2017") || nuevoCarne.Contains("2016") || nuevoCarne.Contains("2024"))
            {
                PropiedadesCodigoQR("El Código SI es válido"+"\n"+"Es : "+nuevoCarne);
                MessageBox.Show("El Carné generado si es válido");
            }
            else
            {
                PropiedadesCodigoQR("El Código NO es válido"+"\n"+"Es : "+nuevoCarne);
                MessageBox.Show("El Carné generado no es válido");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImagenPic_Click(object sender, EventArgs e)
        {

        }
    }
}
   
