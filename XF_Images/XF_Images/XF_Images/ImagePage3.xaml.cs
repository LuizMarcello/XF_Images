﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage3 : ContentPage
    {
        public ImagePage3()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("XF_Images.Images.LogoPhoenix.jpg");
        }
    }
}
