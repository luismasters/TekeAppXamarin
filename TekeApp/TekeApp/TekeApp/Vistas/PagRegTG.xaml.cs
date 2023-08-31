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
    public partial class PagRegTG : ContentPage
    {
        public PagRegTG()
        {
            InitializeComponent();
        }

        private async void  Button_ClickedBG(object sender, EventArgs e)
        {

            try
            {
                string entrada = BandejaGrandes.Text;

                if (int.TryParse(entrada, out int cantidad))
                {
                    int x = cantidad * 420;

                    bool userConfirmed = await DisplayAlert("Confirmación", "¿Estás seguro de registrar " + x.ToString() + " tequeños?", "Sí", "No");

                    if (userConfirmed)
                    {
                        Registro registro = new Registro();
                        registro.Entrada = x;
                        registro.Tamaño = "Grande";
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

        private async void Button_ClickedUG(object sender, EventArgs e)
        {

            try
            {
                string entrada = UnidadesGrandes.Text;

                if (int.TryParse(entrada, out int cantidad))
                {
                    int x = cantidad;

                    bool userConfirmed = await DisplayAlert("Confirmación", "¿Estás seguro de registrar " + x.ToString() + " tequeños?", "Sí", "No");

                    if (userConfirmed)
                    {
                        Registro registro = new Registro();
                        registro.Entrada = x;
                        registro.Tamaño = "Grande";
                        registro.Fecha = DateTime.Now;
                        registro.Salida = 0;

                        // Guardar el registro en la base de datos
                        await App.SQLiteDB.SaveRegistroAsync(registro);

                        string y = x.ToString();
                        await DisplayAlert("Registraste", y + " tequeños", "Exitoso");
                    }

                    UnidadesGrandes.Text = "";
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