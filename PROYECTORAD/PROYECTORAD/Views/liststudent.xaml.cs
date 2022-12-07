using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PROYECTORAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class liststudent : ContentPage
    {
        public liststudent()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // listestuden.ItemsSource = await App.dbemple.listaempleados();
            //liststudent.ItemsSource = await.App.estudianteDB.listalumnos();
            listudent.ItemsSource = await App.estudianteDB.listalumnos();


        }
        private void listudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}