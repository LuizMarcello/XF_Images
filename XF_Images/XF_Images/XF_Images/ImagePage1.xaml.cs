using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage1 : ContentPage
    {
        public ImagePage1()
        {
            InitializeComponent();

            var image = new Image();
            image.Aspect = Aspect.AspectFit;

            image.Source = ImageSource.FromUri(new Uri("http://www.macoratti.net/Imagens/animais/cao2.jpg"));

            //image.Source = new UriImageSource
            //{
            //    Uri = new Uri("http://www.macoratti.net/Imagens/animais/cao2.jpg"),
            //    CachingEnabled = false,
            //    CacheValidity = new TimeSpan(1,0,0,0)
            //};

            //ou:

            //Image image = new Image
            //{
            //    Aspect = Aspect.AspectFill,
            //    Source = new UriImageSource
            //    {
            //        Uri = new Uri("http://www.macoratti.net/Imagens/animais/cao2.jpg"),
            //        CachingEnabled = false,
            //        CacheValidity = new TimeSpan(1, 0, 0, 0)
            //    }
            //};

            Content = image;
        }
    }
}




                

            



               
