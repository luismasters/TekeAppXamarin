using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TekeApp.Data;
using System.IO;

namespace TekeApp
{
    public partial class App : Application
    {
        static SQLiteHelper db;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PagBienvenida());
        }

        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TekeDB.db"));
                }
                return db;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}