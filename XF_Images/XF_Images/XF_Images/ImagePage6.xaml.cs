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
    public partial class ImagePage6 : ContentPage
    {
        public ImagePage6()
        {
            InitializeComponent();

            Image image = new Image
            {
                Source = "http://macoratti.net/Imagens/animais/cao2.jpg",
                Aspect = Aspect.AspectFit
            };

            //Cria uma instância da classe "TapGestureRecognizer"
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();

            //Adiciona o reconhecedor de gestos(objeto image) à coleção "GestureRecognizers"
            image.GestureRecognizers.Add(tapGestureRecognizer);

            //Manipula(tratando) o evento "Tapped"
            //Ação que ocorrerá ao clicar na imagem
            tapGestureRecognizer.Tapped += async (sender, e) =>
            {
                image.Opacity = .5;
                //Colocando um delay
                await Task.Delay(2000);
                image.Opacity = 1;
            };

            Content = image;


        }
    }
}