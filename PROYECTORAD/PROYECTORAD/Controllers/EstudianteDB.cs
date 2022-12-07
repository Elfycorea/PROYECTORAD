using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTORAD.Controllers
{
    public class EstudianteDB
    {
        readonly SQLiteAsyncConnection _conexion;
        // Constructor Vacio
        public EstudianteDB()
        { }

        // Constructor con parametros
        public EstudianteDB(String dbpath)
        {
            // Creando una conexion a base de datos sqlite a partir del path de la base de datos
            _conexion = new SQLiteAsyncConnection(dbpath);

            // Crear las tablas correspondientes en la base de datos de sqlite
            _conexion.CreateTableAsync<Models.Estudiante>().Wait();
        }

        // Create
        public Task<int> StoreEstudent(Models.Estudiante estudent)
        {
            if (estudent.id != 0)
            {
                return _conexion.UpdateAsync(estudent);
            }
            else
            {
                return _conexion.InsertAsync(estudent);

            }
        }

        // Read

        public Task<List<Models.Estudiante>> listalumnos()
        {
            return _conexion.Table<Models.Estudiante>().ToListAsync();
        }

        public Task<Models.Estudiante> getempleado(int pid)
        {
            return _conexion.Table<Models.Estudiante>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> Deleteempleado(Models.Estudiante emple)
        {
            return _conexion.DeleteAsync(emple);
        }



    }
}
