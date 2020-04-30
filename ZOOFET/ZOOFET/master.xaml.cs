using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZOOFET
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class master : ContentPage
    {
        public master()
        {
            InitializeComponent();
        }

        private async void animales_Clicked(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new animales());
        }

        private async void contactenos_Clicked(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new contactenos());
        }

        private async void reservas_Clicked(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new reservas());
        }

        private async void login_admin_Clicked(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new login_admin());
        }
    }
}