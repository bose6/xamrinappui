using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var nav = new NavigationPage(new ContentPage { Title = "Page" });
            nav.BarBackgroundColor = Color.Yellow;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
             Navigation.PushAsync(new policy());

        }
    }
}
