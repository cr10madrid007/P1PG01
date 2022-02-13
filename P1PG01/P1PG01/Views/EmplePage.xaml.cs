using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P1PG01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmplePage : ContentPage
    {
        public EmplePage()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var pagina1 = new Views.PageCreateEmple();
            await Navigation.PushAsync(pagina1);
        }

        protected override  async void OnAppearing()
        {
            base.OnAppearing();
            ListaEmpleados.ItemsSource = await App.BaseDatos.listaempleados();
        }

        

        private  async void ListaEmpleados_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Models.Empleados item = (Models.Empleados)e.Item;
            var newpage = new Views.PageCreateEmple();
            newpage.BindingContext = item;
            await Navigation.PushAsync(newpage);
        }

        private async void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            var newpage = new Views.PhotoPage();
            await Navigation.PushAsync(newpage);
        }

        private async void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {
            var newpage = new Views.PageTTS();
            await Navigation.PushAsync(newpage);

        }

        private async void ToolbarItem_Clicked_3(object sender, EventArgs e)
        {
            var newpage = new Views.MapPage();
            await Navigation.PushAsync(newpage);
        }

       

        private async void ToolbarItem_Clicked_5(object sender, EventArgs e)
        {
            var newpage = new MainPage();
            await Navigation.PushAsync(newpage);
        }
    }
}