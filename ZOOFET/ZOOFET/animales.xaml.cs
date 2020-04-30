using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using ZOOFET.models;
using ZOOFET.services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ZOOFET
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class animales : ContentPage
    {
        // objeto encargado de realizar las peticiones a la api
        public Animales_services animalesService = new Animales_services();

        public animales()
        {
            InitializeComponent();
        }


        /*Metodo encargado de ejecutar el codigo interno cuando se muestre la pagina por primera vez
         * 
         */
        protected override async void OnAppearing()
        {
            Lista_animales.ItemsSource = await animalesService.GetAnimals();
            base.OnAppearing();

        }




    }
}