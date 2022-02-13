using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



using Plugin.Geolocator;
using Xamarin.Forms.Maps;

namespace P1PG01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Pin ubicacion = new Pin();
            ubicacion.Label = "San Pedro Sula";
            ubicacion.Address = "Cerca de la UTH";
            ubicacion.Position = new Position(15.5510539, -88.0109923);
            Mapa.Pins.Add(ubicacion);


            Mapa.MoveToRegion(new MapSpan(new Position(15.5510539, -88.0109923), 1, 1));



            var localizacion = CrossGeolocator.Current;
            if (localizacion != null)
            {
                localizacion.PositionChanged += localizacion_positionChanged;
            


                        if (!localizacion.IsListening)
                        {
                            await localizacion.StartListeningAsync(TimeSpan.FromSeconds(10), 100);
                        }

            }
        }

        private void localizacion_positionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            var posicion_mapa = new Position(e.Position.Latitude, e.Position.Longitude);
            Mapa.MoveToRegion(new MapSpan(posicion_mapa, 1, 1));
        }
    }
}