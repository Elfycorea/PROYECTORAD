using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PROYECTORAD
{
    public partial class App : Application
    {
        static Controllers.EstudianteDB estudiantedb;

        public static Controllers.EstudianteDB estudianteDB
        {
            get
            {
                if (estudiantedb == null)
                {
                    String DBName = "ESTUDIANTE.db3";
                    String PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    estudiantedb = new Controllers.EstudianteDB(PathDB);
                }

                return estudiantedb;
            }
        }
        // para menu 
        public static MasterDetailPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
