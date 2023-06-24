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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, string edad, string fecha, string ciudad, double pagoMensual, string pais, double pagoTotal, double montoInicial )
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario Conectado: " + usuario;

            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblEdad.Text = edad;
            lblFecha.Text = fecha;
            lblCiudad.Text = ciudad;
            lblPais.Text = pais;
            lblMontoInicial.Text = montoInicial.ToString();
            lblPagoTotal.Text = pagoTotal.ToString();
            lblPagoMensual.Text = pagoMensual.ToString();
        }


        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());

        }
    }
}