using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public IList<Cidades> Cidades { get; private set; }
        public Lista()
        {
            InitializeComponent();
            BindingContext = new CidadeViewModel();

          
        }
    }
}