using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace XF_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage4 : ContentPage
    {
        public ImagePage4()
        {
            InitializeComponent();

            //image2.Source = ImageSource.FromFile("icon.png");

            //image2.Source = Device.RuntimePlatform(
            //    iOS: ImageSource.FromFile("icon.png"),
            //    Android: ImageSource.FromFile("icon.png"),
            //    Windows: ImageSource.FromFile("icon.png") 
            //    );
        }
    }
}
            
