using System;
using System.Collections.Generic;
using System.Text;
using ZOOFET.Models;
using Xamarin.Forms;
using ZOOFET.Services;
using System.Collections.ObjectModel;

namespace ZOOFET.ViewModels
{
    public class ListarAnimalesViewModel : BaseViewModel
    {

        private ApiService apiService;
        private ObservableCollection<listar_animales> animales;

        public ObservableCollection<listar_animales> Animales
        {
            get { return this.animales; }
            set { this.SetValue(ref animales, value); }

        }
        
        public ListarAnimalesViewModel()
        {
            this.apiService = new ApiService();
            this.CargarAnimales();
        }

        private async void CargarAnimales()
        {
            
            var respnse = await this.apiService.GetList<listar_animales>("animales/listar_animales/");

            if (!respnse.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", respnse.Message, "Aceptar");
                return;
            }

            var Listar = (List<listar_animales>)respnse.Result;
            this.Animales = new ObservableCollection<listar_animales>(Listar);
        }

    }
}
