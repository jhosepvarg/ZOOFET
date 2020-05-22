using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using ZOOFET.Models;
using ZOOFET.services;
using ZOOFET.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ZOOFET
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class animales : ContentPage
    {

        ListarAnimalesViewModel ViewModels;


        public animales()
        {
            InitializeComponent();

            BindingContext = ViewModels = new ListarAnimalesViewModel();

        }





    }
}