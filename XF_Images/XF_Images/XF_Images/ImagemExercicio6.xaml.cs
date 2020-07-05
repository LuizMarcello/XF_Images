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
    public partial class ImagemExercicio6 : ContentPage
    {
        public ImagemExercicio6()
        {
            InitializeComponent();

            //Neste exemplo usando um FileImageSource para
            //carregar a imagem, por isso precisamos definir a 
            //propriedade File para uma string com o nome do arquivo
            //Image image = new Image
            //{
            //    Source = new FileImageSource
            //    {
            //        File = Device.OnPlatform(
            //               iOS: "Icon-Small-40.png",
            //               Android: "Icon.png",
            //               WinPhone: "Assets/StoreLogo.png")
            //    },
            //};

            //var image = new Image();

            //image.Source = Device.OnPlatform
            //    (iOS: ImageSource.FromFile(""),
            //     Android: ImageSource.FromFile(""),
            //     WinPhone: ImageSource.FromFile("")
            //     );

            //Content = new StackLayout 
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Children =
            //    {
            //        image
            //    }
            //};
        }
    }
}
            




