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
	public partial class PagBtnReg : ContentPage
	{

        public PagBtnReg ()
		{
			InitializeComponent ();
		}

        private void Button_ClickedTC(object sender, EventArgs e)
        {
             PagRegistro pagRegistro = new PagRegistro ();
            Navigation.PushAsync ( pagRegistro );
        }

        private void Button_ClickedTG(object sender, EventArgs e)
        {
            PagRegTG pagRegTG = new PagRegTG ();   
            Navigation.PushAsync ( pagRegTG );

        }
    }
}