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
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // listestuden.ItemsSource = await App.dbemple.listaempleados();
            //liststudent.ItemsSource = await.App.estudianteDB.listalumnos();
            
        

        }

        private async void btnregistro_Clicked(object sender, EventArgs e)
        {
            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new PageEstudiante());
        }

        private async void btnlist_Clicked(object sender, EventArgs e)
        {
            //  App.MasterDet.IsPresented = false;
            //await App.MasterDet.Detail.Navigation.PushAsync(new Views.PageEstudiante());
           // liststudent.ItemsSource = await App.estudianteDB.listalumnos();
        }

        private void liststudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private async void btnlista_Clicked(object sender, EventArgs e)
        {

            App.MasterDet.IsPresented = false;
            await App.MasterDet.Detail.Navigation.PushAsync(new  Views.liststudent());
        }
    }
}