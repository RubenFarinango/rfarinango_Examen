using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rfarinangoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resumen : ContentPage
    {
        public resumen(string datos, string nombreEstudiante, double montoTotal)
        {
            InitializeComponent();
            lblUsuario.Text = datos;
            lblnombreEstudiante.Text = nombreEstudiante;
            lblmontoTotal.Text = montoTotal.ToString();
        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Información", "Examen Rubén Farinango", "Cerrar");
        }
    }
}