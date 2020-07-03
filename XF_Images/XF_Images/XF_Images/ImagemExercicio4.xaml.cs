using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace XF_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagemExercicio4 : ContentPage
    {
        public ImagemExercicio4()
        {
            InitializeComponent();

            string uri = "http://macoratti.net/Imagens/animais/cao2.jpg";

            image.Source = new UriImageSource 
            {
                Uri = new Uri(uri),
                CachingEnabled = false
            };
        }
    }
}
