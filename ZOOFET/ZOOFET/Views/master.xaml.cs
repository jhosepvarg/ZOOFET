using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZOOFET.Views;

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

        private async void InsertarAnimales_Clicked(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new InsertaAnimales());
        }

        private async void AddContacto_Clicked(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new AddContactos());
        }

        private async void ListarContactos_Clicked(object sender, EventArgs e)
        {
            await App.MasterD.Detail.Navigation.PushAsync(new Contactos());
        }
    }
}