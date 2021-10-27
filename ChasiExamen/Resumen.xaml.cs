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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre,string total,string usuario)
        {
            InitializeComponent();
            //visualizamos en el label el usuario insertado
            lblNombre.Text = nombre;
            lblTotal.Text = total;

            lblUsuario.Text = usuario;



        }
    }
}