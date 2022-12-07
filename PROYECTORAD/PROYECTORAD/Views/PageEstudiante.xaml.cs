using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PROYECTORAD.Views
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageEstudiante : ContentPage
    {
        public PageEstudiante()
        {
            InitializeComponent();
            
          
           
        }

        private async void btnregistrar_Clicked(object sender, EventArgs e)
        {
           
                var estudent = new Models.Estudiante
                {
                    id = Convert.ToInt32(txtid.Text),
                    nombres = txtnombres.Text,
                    apellidos = txtapellidos.Text,
                    fechanacimiento = Convert.ToDateTime(txtfechanacimiento.Text),
                    pais = PickOptions.Default.PickerTitle,
                    departamento = txtdepto.Text,
                    municipio = txtmunicipio.Text,
                    estadocivil = PickOptions.Default.PickerTitle,
                    telefono = txtelefono.Text,

                };
                if (await App.estudianteDB.StoreEstudent(estudent) > 0)
                    await DisplayAlert("Aviso", "Registro Ingresado Con Exito!!", "OK");


        }

        
    }
}