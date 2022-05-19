using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace МатулевскаяПР11
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            Label header = new Label() { Text = "Привет из Xamarin Forms" };
            this.Content =header;
        }
    }
}
