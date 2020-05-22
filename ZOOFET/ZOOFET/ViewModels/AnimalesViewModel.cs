using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using ZOOFET.Services;
using ZOOFET.Models;

namespace ZOOFET.ViewModels
{
    public class AnimalesViewModel : BaseViewModel
    {
        private ApiService apiService;

        public InsertarAnimales Datos { get; set; }

        public AnimalesViewModel()

        {
            this.apiService = new ApiService();

            this.Datos = new InsertarAnimales();
        }

        public ICommand AddAnimalesButtonCommand => new Command(AddAnimales);

        public async void AddAnimales()
        {
            if ( await this.ValidarDatosAnimalesAsync())
            {
                return;
            }

            var response = await this.apiService.Post("animales/add_animales", this.Datos);

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Acept");
                return;
            }

            else

            {
                await Application.Current.MainPage.DisplayAlert("Exitoso", response.Message, "Acept");
            }


        }

        public async Task<bool> ValidarDatosAnimalesAsync()
        {
            if (this.Datos.nombre == null)
            {
                await Application.Current.MainPage.DisplayAlert("Cuidado", "Asegurese de Ingresar el nombre", "Aceptar");
                return true;
            }

            if (this.Datos.descripcion == null)

            {
                await Application.Current.MainPage.DisplayAlert("Cuidado", "Ingrese Una Descripcion", "Aceptar");
                return true;
            }

            return false;

        }

    }


}
