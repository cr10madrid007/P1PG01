using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace P1PG01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnPagina_Clicked(object sender, EventArgs e)
        {
            var Contact = new Models.Contactos
            {
                Nombre = this.txtNombre.Text,
                Edad =Convert.ToInt32(this.txtEdad.Text),
                Ocupacion= this.txtOcupacion.SelectedItem.ToString(),
                Pais=this.txtPais.Text

            };
            var pagina = new PageMain();
            pagina.BindingContext = Contact;

            await Navigation.PushAsync(pagina);
            // await Navigation.PushAsync(new PageMain());

        }
    }
}
