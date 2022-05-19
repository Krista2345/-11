using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace МатулевскаяПР11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Label label1 = new Label()
            {
                Text = "Матулевская Кристина Владимировна",
                FontSize = 14,
                TextColor = Color.Black

            };
            Label label2 = new Label()
            {
                Text = "Группа:ПКС31",
                FontSize = 14,
                TextColor = Color.Red
            };

            Label label3 = new Label()
            {
                Text = "Мои интересы: 1)Рисование; 2)Творчество 3)Рукоделие 4)Чтение 5)Пишу рассказы",
                FontSize = 14,
                TextColor = Color.Black
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { label1, label2, label3 }
            };
            stackLayout.Spacing = 8;
            this.Content = stackLayout;
        }
    }
}
