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
    public partial class ImagemExercicio10 : ContentPage
    {
        private int _IdImagemAtual = 1;

        public ImagemExercicio10()
        {
            InitializeComponent();

            _IdImagemAtual = 1;
            CarregarImagem();
        }

        void CarregarImagem()
        {
            imagge.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://macoratti.net/Imagens/animais/cao{0}.jpg", _IdImagemAtual)),
                CachingEnabled = false
            };
        }
        private void Anterior_Clicked(object sender, EventArgs e)
        {
            _IdImagemAtual--;
            //if (_IdImagemAtual == 0)
            //    _IdImagemAtual = 10;

            CarregarImagem();
        }

        private void Proximo_Clicked(object sender, EventArgs e)
        {
            _IdImagemAtual++;
            //if (_IdImagemAtual == 11)
            //    _IdImagemAtual = 1;

            CarregarImagem();
        }
    }
}







