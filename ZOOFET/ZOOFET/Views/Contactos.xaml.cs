using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZOOFET.ViewModels;

namespace ZOOFET.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contactos : ContentPage
    {
        ListarContactosViewModel ViewModel;
        public Contactos()
        {
            InitializeComponent();

            BindingContext = ViewModel = new ListarContactosViewModel();
        }
    }
}