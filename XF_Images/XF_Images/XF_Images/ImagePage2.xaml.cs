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
    public partial class ImagePage2 : ContentPage
    {
        public ImagePage2()
        {
            InitializeComponent();

            image.Source = new UriImageSource
            {
                Uri = new Uri("http://www.macoratti.net/Imagens/animais/tigre.jpg"),
                CachingEnabled = false
            };

            //ActivityIndicator indicator = new ActivityIndicator 
            //{
            //    Color = Color.Black
            //};

            //indicator.SetBinding(ActivityIndicator.IsRunningProperty, "IsLoading");
            //indicator.BindingContext = image;
        }
    }
}
