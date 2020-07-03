using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagemExercicio1_3 : ContentPage
    {
        public ImagemExercicio1_3()
        {
            InitializeComponent();

            //string uri = "http://macoratti.net/Imagens/animais/cao2.jpg";
            //Image image = new Image
            //{
            //    Source = ImageSource.FromUri(new Uri(uri)),
            //    Aspect = Aspect.AspectFill
            //};
            //Content = image;



            string uri = "http://macoratti.net/Imagens/animais/cao2.jpg";
            Content = new Image
            {
                Source = ImageSource.FromUri(new Uri(uri)),
                Aspect = Aspect.AspectFill
            };
        }
    }
}






