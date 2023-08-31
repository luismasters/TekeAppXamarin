using System;
using System.Collections.Generic;
using System.Linq;
using TekeApp.Models;
using Xamarin.Forms;

namespace TekeApp
{
    public partial class PagStock : ContentPage
    {
        public PagStock()
        {
            InitializeComponent();
            LoadStock();
        }

        private void LoadStock()
        {
            try
            {
                // Consultar la base de datos para obtener registros de tamaños chicos
                List<Registro> registrosChicos = App.SQLiteDB.GetRegistrosAsync().Result
                    .Where(registro => registro.Tamaño == "Chico")
                    .ToList();

                // Calcular el stock actual sumando las entradas y restando las salidas
                int stockChicos = registrosChicos.Sum(registro => registro.Entrada - registro.Salida);

                // Actualizar el texto del Label con el stock actual
                StockLabel.Text = $"Stock Actual de Unidades Chicos: {stockChicos}";
                StockLabelB.Text = $"Equivalentes a: {stockChicos/500} bandejas";


                List<Registro> registrosGrandes = App.SQLiteDB.GetRegistrosAsync().Result
                    .Where(registro => registro.Tamaño == "Grande")
                    .ToList();

                // Calcular el stock actual sumando las entradas y restando las salidas
                int stockGrande = registrosGrandes.Sum(registro => registro.Entrada - registro.Salida);

                // Actualizar el texto del Label con el stock actual
                StockLabelG.Text = $"Stock Actual de Unidades Chicos: {stockGrande}";
                StockLabelBG.Text = $"Equivalentes a: {stockGrande / 420} bandejas";



            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Ocurrió un error: " + ex.Message, "Ok");










            }
        }
    }
}