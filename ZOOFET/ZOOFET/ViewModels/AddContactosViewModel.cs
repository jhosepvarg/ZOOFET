using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using System.Threading.Tasks;
using ZOOFET.Services;
using ZOOFET.Models;
using Xamarin.Forms;

namespace ZOOFET.ViewModels
{
    public class AddContactosViewModel : BaseViewModel
    {
        private ApiService apiService;

        public InsertarContactos Datos { get; set; }

        public AddContactosViewModel()
        {
            this.apiService = new ApiService();

            this.Datos = new InsertarContactos();
        }

        public ICommand AddContactosButtonCommand => new Command(AddContactos);

        public async void AddContactos()
        {
            if (await this.ValidarDatosContactosAsync())
            {
                return;
            }

            var response = await this.apiService.Post("Contact/add_contactos", this.Datos);

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Aceptar");
                return;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Exitoso", response.Message, "Aceptar");
            }
        }

        public async Task<bool> ValidarDatosContactosAsync()
        {
            if (this.Datos.nombre == null)
            {
                await Application.Current.MainPage.DisplayAlert("Cuidado", "Asegure que ingresó el nombre", "Aceptar");
                return true;
            }

            if (this.Datos.telefono == null)
            {
                await Application.Current.MainPage.DisplayAlert("Cuidado", "Asegure que ingresó el Telefono", "Aceptar");
                return true;
            }
            return false;
        }

    }
}
