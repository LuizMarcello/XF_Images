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
    public partial class ImagemExercicio5 : ContentPage
    {
        public ImagemExercicio5()
        {
            InitializeComponent();

            //Content = new Image
            //{
            //    Source = ImageSource.FromResource("XF_Images.Images.LogoPhoenix.jpg"),
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center
            //};
        }
    }
}
