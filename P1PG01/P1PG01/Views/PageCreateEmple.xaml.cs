using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using P1PG01.Models;

namespace P1PG01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCreateEmple : ContentPage
    {
        public PageCreateEmple()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            var emple = new Empleados
            {
                nombres = Nombres.Text,
                apellidos = Apellidos.Text,
                edad = Convert.ToInt32(Edad.Text),
                fecha_nac = Fecha.Date,
                ocupacion = Ocupacion.Text
            };
            var resultado= await App.BaseDatos.EmpleadoGuardar(emple);
            if (resultado != 0)
            {
                await DisplayAlert("Aviso", "Empleado Ingresado con exito!!", "OK");
            }else
            {
                await DisplayAlert("Aviso", "Error!!", "OK");
            }
            await Navigation.PopAsync();
        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Clicked(object sender, EventArgs e)
        {

        }
    }
}