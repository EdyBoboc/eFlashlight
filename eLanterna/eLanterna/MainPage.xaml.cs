using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace eLanterna
{
    public partial class MainPage : ContentPage
    {
        enum StareLanterna
        {
            Aprinsa,
            Stinsa
        }; StareLanterna stare;

        public MainPage()
        {
            InitializeComponent();
            stare = StareLanterna.Stinsa;
        }

        private void btnLanterna_Clicked(object sender, EventArgs e)
        {
            if(stare == StareLanterna.Stinsa)
            {
                btnLanterna.Text = "Stinge lanterna";
                btnLanterna.BackgroundColor = Color.FromHex("#57c4f2");
                btnLanterna.TextColor = Color.FromHex("#0c1b21");
                Flashlight.TurnOnAsync();
                stare = StareLanterna.Aprinsa;
            }
            else
            {
                btnLanterna.Text = "Aprinde lanterna";
                btnLanterna.BackgroundColor = Color.FromHex("#222222");
                btnLanterna.TextColor = Color.FromHex("#f5f5f5");
                Flashlight.TurnOffAsync();
                stare = StareLanterna.Stinsa;
            }
        }
    }
}
