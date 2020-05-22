using System;
using System.Collections.Generic;
using System.Text;
using ZOOFET.Models;
using ZOOFET.Services;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ZOOFET.ViewModels
{
    public class ListarContactosViewModel : BaseViewModel
    {

        private ApiService apiService;
        private ObservableCollection<ListarContactos> contactos;

        public ObservableCollection<ListarContactos> Contactos
        {
            get { return this.contactos; }
            set { this.SetValue(ref contactos, value); }
        }

        public ListarContactosViewModel()
        {
            this.apiService = new ApiService();
            this.CargarContactos();
        }

        private async void CargarContactos()
        {
            var respnse = await this.apiService.GetList<ListarContactos>("Contact/listar_contactos/");

            if (!respnse.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", respnse.Message, "Aceptar");
                return;
            }

            var Listar = (List<ListarContactos>)respnse.Result;
            this.Contactos = new ObservableCollection<ListarContactos>(Listar);

        }

    }
}
