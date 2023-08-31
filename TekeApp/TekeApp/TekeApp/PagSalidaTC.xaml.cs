using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekeApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekeApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagSalidaTC : ContentPage
    {
        public PagSalidaTC()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                string Salida = BandejaChicos.Text;

                if (int.TryParse(Salida, out int cantidad))
                {
                    int x = cantidad * 500;

                    bool userConfirmed = await DisplayAlert("Confirmación", "¿Estás seguro de Sacar " + x.ToString() + " tequeños?", "Sí", "No");

                    if (userConfirmed)
                    {
                        Registro registro = new Registro();
                        registro.Salida = x;
                        registro.Tamaño = "Chico";
                        registro.Fecha = DateTime.Now;
                        registro.Entrada = 0;

                        // Guardar el registro en la base de datos
                        await App.SQLiteDB.SaveRegistroAsync(registro);

                        string y = x.ToString();
                        await DisplayAlert("Salieron", y + " tequeños", "Exitoso");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Por favor ingresa un valor numérico válido", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Ocurrió un error: " + ex.Message, "Ok");
            }





        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {



            try
            {
                string Salida = UnidadesChicos.Text;

                if (int.TryParse(Salida, out int cantidad))
                {
                    int x = cantidad;

                    bool userConfirmed = await DisplayAlert("Confirmación", "¿Estás seguro de Sacar " + x.ToString() + " tequeños?", "Sí", "No");

                    if (userConfirmed)
                    {
                        Registro registro = new Registro();
                        registro.Salida = x;
                        registro.Tamaño = "Chico";
                        registro.Fecha = DateTime.Now;
                        registro.Entrada = 0;

                        // Guardar el registro en la base de datos
                        await App.SQLiteDB.SaveRegistroAsync(registro);

                        string y = x.ToString();
                        await DisplayAlert("Salieron", y + " tequeños", "Exitoso");
                    }
                }
                else
                {
                    await DisplayAlert("Error", "Por favor ingresa un valor numérico válido", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Ocurrió un error: " + ex.Message, "Ok");
            }
















        }
    }
}