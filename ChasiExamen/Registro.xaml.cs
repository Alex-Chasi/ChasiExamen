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
    public partial class Registro : ContentPage 
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            //visualizamos en el label el usuario insertado
            lblUsuario.Text = usuario;
        }
        //agregamos (async) el hilo de conexion entre ventanas
        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {
                //almacenamos en variable los datos del usuario ingresado 
                string nombre = txtNombre.Text;

                string total = txtTotal.Text;

                string usuario = txtNombre.Text;


                double montoi = Convert.ToInt32(txtMontoInicial.Text);

                if (montoi == 1800)
                {

                    double porcentaje = montoi * 0.05;

                    double portatotal = porcentaje * 3;

                    double pagom = Convert.ToInt32(txtPagoMensual.Text);
                    if (pagom >= 1)
                    {

                        //navega a otra ventana 
                        await Navigation.PushAsync(new Resumen(nombre, total,usuario));

                        //valor total a calcular
                        double cal1 = montoi - pagom;
                        double cal2 = (cal1 / 3);

                        double cal3 = cal2 * 3;

                        double totalpagar = cal3 + portatotal;

                        //Visualizar el resultado en pantalla.
                        txtTotal.Text = totalpagar.ToString();
                        

                        await DisplayAlert("Guardado", "Elemento guardado con exito", "OK");

                    }
                    else if (pagom <= 1)
                    {
                        await DisplayAlert("Ingrese", "Ingrese Pago Mensual Mayor a 1", "OK");

                    }

                }
                else if (montoi >= 1800)
                {
                    await DisplayAlert("Ingrese", "Ingrese Monto Menor a 1800", "OK");
                }
                else if (montoi <= 1)
                {
                    await DisplayAlert("Ingrese", "Ingrese Monto Mayor a 1", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de alerta", ex.Message, "Ok");
            }

        }
    }
}