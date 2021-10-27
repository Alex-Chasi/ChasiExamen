using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChasiExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        //agregamos (async) el hilo de conexion entre ventanas
        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //almacenamos en variable los datos del usuario ingresado 
                string usuario = txtUsuario.Text;

                /*
                //permite abrir la ventana de notas (MainPage)
                await Navigation.PushAsync(new MainPage(usuario));
                */

                //login validado
                if (txtUsuario.Text == "estudiante2021" && txtContrasenia.Text == "uisrael2021")
                {
                    //permite abrir la ventana de notas (MainPage)
                    await Navigation.PushAsync(new Registro(usuario));
                    await DisplayAlert("Usuario", "Usuario Conectado", "OK");
                }
                else if (txtUsuario.Text != "null")
                {
                    //mensaje de validacion de usuario
                    await DisplayAlert("Usuario", "Usuario InCorrecto", "OK");

                    // await Navigation.PushAsync(new login());
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
                //throw;
            }

        }
    }
}