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
    public partial class AddContactos : ContentPage
    {
        AddContactosViewModel ViewModels;
        public AddContactos()
        {
            InitializeComponent();

            BindingContext = ViewModels = new AddContactosViewModel();
        }
    }
}