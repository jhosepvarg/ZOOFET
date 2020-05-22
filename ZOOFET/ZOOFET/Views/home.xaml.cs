using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZOOFET
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class home : MasterDetailPage
    {
        public home()
        {
            InitializeComponent();
            this.Master = new master();
            this.Detail = new NavigationPage(new detail());

            App.MasterD = this;
        }
    }
}