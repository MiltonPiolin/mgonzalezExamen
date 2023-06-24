using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mgonzalezExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuarioActivo;
        string nombre;
        string apellido;
        string edad;
        string fecha;
        string ciudad;
        string pais;
        double montoInicial;
        double pagoMensual;
        double pagoTotal;

        public Registro( string usuario)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario Conectado: " + usuario;
            usuarioActivo = usuario;
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {

        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
                if (montoInicial >= 1500 || montoInicial<= 0)
                {
                    DisplayAlert("ERROR", "El Monto inicial no esta en el rango de mayor a 0 a menor de 1500", "Cerrar");
                    txtMontoInicial.Text = "";


                }
            }
            catch (Exception ex)
            {
                //DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }



        private void btnCalcularPagoMensual_Clicked(object sender, EventArgs e)
        {
            montoInicial = Convert.ToDouble(txtMontoInicial.Text);

            if(montoInicial == 0)
            {
                DisplayAlert("ERROR", "Debe ingresar un valor en pago inicial", "Cerrar");
            }
            else
            {
                pagoMensual = (1500 - montoInicial) / 4 + (1500 * 0.04);
                
                txtPagoMensual.Text = pagoMensual.ToString();
            }

            
                               
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            edad = txtEdad.Text;
            fecha = pkrFecha.Date.ToString();
            ciudad = pkrCiudad.Items[pkrCiudad.SelectedIndex];
            pais = pkrPais.Items[pkrPais.SelectedIndex];

            pagoTotal = montoInicial + pagoMensual * 4;

            Navigation.PushAsync(new Resumen(usuarioActivo, nombre, apellido,edad,fecha,ciudad,pagoMensual,pais,pagoTotal,montoInicial));

        }
    }
}