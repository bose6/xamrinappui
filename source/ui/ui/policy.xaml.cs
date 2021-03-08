using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ui
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class policy : ContentPage
    {
        public policy()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            

        }

        private void Button_back(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
}