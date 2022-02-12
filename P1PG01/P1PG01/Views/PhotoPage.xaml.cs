using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

using Plugin.Media;


namespace P1PG01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage()
        {
            InitializeComponent();
        }

        private async void btnfoto_Clicked(object sender, EventArgs e)
        {
            var takepic = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions {
                Directory = "PhotoApp", 
                Name ="TEST.jpg"
            });

            await DisplayAlert("Ubicación del archivo", takepic.Path, "OK");


            if (takepic != null)
            {
                foto.Source = ImageSource.FromStream(() => { return takepic.GetStream(); });

            }



            var Sharephoto = takepic.Path;
            await Share.RequestAsync(new ShareFileRequest { 
                Title="Foto", 
                File = new ShareFile(Sharephoto) 
            });
        }
    }
}