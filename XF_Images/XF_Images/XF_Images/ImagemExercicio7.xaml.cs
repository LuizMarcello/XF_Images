using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagemExercicio7 : ContentPage
    {
        public ImagemExercicio7()
        {
            InitializeComponent();

            var image = new Image
            {
                Source = "http://macoratti.net/Imagens/animais/cao1.jpg",
                Aspect = Aspect.AspectFit
            };

            var tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.NumberOfTapsRequired = 2;

            image.GestureRecognizers.Add(tapGestureRecognizer);

            tapGestureRecognizer.Tapped += async(sender, e) => 
            {
                image.Opacity = .5;
                await Task.Delay(2000);
                image.Opacity = 1;
                await DisplayAlert("Aviso","Você clicou na imagem","OK");
            };

            Content = image;
        }
    }
}



