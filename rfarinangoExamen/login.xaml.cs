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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string clave = "uisrael2023";
            if (usuario == txtUsuario.Text && clave == txtClave.Text)
            {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("Credenciales", "Usuario/Contraseña Incorrecto", "Cerrar");
            }
        }
    }
}