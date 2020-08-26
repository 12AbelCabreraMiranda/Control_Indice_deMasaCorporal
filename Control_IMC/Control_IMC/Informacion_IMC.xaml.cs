using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Control_IMC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Informacion_IMC : ContentPage
    {
        public Informacion_IMC()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}