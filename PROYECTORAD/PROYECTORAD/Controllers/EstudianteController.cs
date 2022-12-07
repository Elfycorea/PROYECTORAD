using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using PROYECTORAD.Models;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace PROYECTORAD.Controllers
{
    public class EstudianteController
    {
        public async static Task<List<Models.Estudiante>> getAlumnos()
        {
            List<Models.Estudiante> listalumnos = new List<Models.Estudiante>();

            try
            {

                using (HttpClient clientRequest = new HttpClient())
                {
                    var response = await clientRequest.GetAsync(Configuracion.GetServiceList);

                    if (response.IsSuccessStatusCode)
                   {
                        var contenido = response.Content.ReadAsStringAsync().Result;
                        listalumnos = JsonConvert.DeserializeObject<List<Models.Estudiante>>(contenido);

                    }

                }
                return listalumnos;

            }
            catch (Exception ex)
            {
                ex.ToString();
                return listalumnos;
            }


        }


        /*public async static Task<int> CreateAlum(Models.Estudiante alum)
        {
            String JsonObject = JsonConvert.SerializeObject(alum);
            StringContent contenido = new StringContent(JsonObject, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;

            using (HttpClient client = new HttpClient())
            {
                response = await client.PostAsync(Configuracion.PostServiceList, contenido);

                if (response.IsSuccessStatusCode)
                {
                    var resultado = response.Content.ReadAsStringAsync().Result;
                    return 1;
                }
                else
                {
                    return 0;
                }
            }


        }*/


    }
}

