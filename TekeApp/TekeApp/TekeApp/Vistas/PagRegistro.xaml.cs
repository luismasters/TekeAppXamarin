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
    public partial class PagRegistro : ContentPage
    {
        public PagRegistro()
        {
            InitializeComponent();
        }

        private async void Button_ClickedBChicos(object sender, EventArgs e)
        {
            try
            {
                string entrada = BandejaChicos.Text;

                if (int.TryParse(entrada, out int cantidad))
                {
                    int x = cantidad * 500;

                    bool userConfirmed = await DisplayAlert("Confirmación", "¿Estás seguro de registrar " + x.ToString() + " tequeños?", "Sí", "No");

                    if (userConfirmed)
                    {
                        Registro registro = new Registro();
                        registro.Entrada = x;
                        registro.Tamaño = "Chico";
                        registro.Fecha = DateTime.Now;
                        registro.Salida = 0;

                        // Guardar el registro en la base de datos
                        await App.SQLiteDB.SaveRegistroAsync(registro);

                        string y = x.ToString();
                        await DisplayAlert("Registraste", y + " tequeños", "Exitoso");
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

        private async void Button_ClickedUChicos(object sender, EventArgs e)
        {
            try
            {
                string entrada = UnidadesChicos.Text;

                if (int.TryParse(entrada, out int cantidad))
                {
                    int x = cantidad;

                    bool userConfirmed = await DisplayAlert("Confirmación", "¿Estás seguro de registrar " + x.ToString() + " tequeños?", "Sí", "No");
if(userConfirmed) { 

                    Registro registro = new Registro();
                    registro.Entrada = x;
                    registro.Tamaño = "Chico";
                    registro.Fecha = DateTime.Now;
                    registro.Salida = 0;

                    // Guardar el registro en la base de datos
                    await App.SQLiteDB.SaveRegistroAsync(registro);

                    string y = x.ToString();
                    await DisplayAlert("Registraste", entrada.ToString() + " tequeños", "Exitoso");}
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