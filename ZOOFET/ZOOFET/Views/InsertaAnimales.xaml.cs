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
    public partial class InsertaAnimales : ContentPage
    {
        AnimalesViewModel ViewModel;
        public InsertaAnimales()
        {
            InitializeComponent();

            BindingContext = ViewModel = new AnimalesViewModel();

        }
    }
}