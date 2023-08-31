using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagBienvenida : ContentPage
    {
        public PagBienvenida()
        {
            InitializeComponent();
        }

        private void Button_ClickedRegistro(object sender, EventArgs e)
        {
        
             PagBtnReg pagRegistro = new PagBtnReg();
              Navigation.PushAsync(pagRegistro);
        }

        private void Button_ClickedVerStock(object sender, EventArgs e)
        {
            PagStock pagStock = new PagStock();
            Navigation.PushAsync(pagStock);



        }

        private void Button_ClickedSalida(object sender, EventArgs e)
        {

            PagBtnSalida pagStock = new PagBtnSalida();
            Navigation.PushAsync(pagStock);





            DisplayAlert("titulo", "Salidas", "Volver");

        }


    }
}