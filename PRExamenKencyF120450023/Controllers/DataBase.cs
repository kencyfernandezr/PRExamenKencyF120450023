using SQLite;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PRExamenKencyF120450023.Controllers
{
    public class DataBase
    {
        readonly SQLiteAsyncConnection _connection;
        public DataBase() { }


        public DataBase(string dbpath)
        {
            _connection = new SQLiteAsyncConnection(dbpath);

            _connection.CreateTableAsync<Models.Estudiantes>().Wait();



        }
        public Task<int> AddEstudiante(Models.Estudiantes est)
        {
            if (est.id == 0)
            {
                return _connection.InsertAsync(est);
            }
            else
            {
                return _connection.UpdateAsync(est);
            }

        }
        public Task<Models.Estudiantes> ObtenerEstudiante(int pid)
        {
            return _connection.Table<Models.Estudiantes>().Where(i => i.id == pid).FirstOrDefaultAsync();
        }

        public Task<int> DeleteEstudiante(Models.Estudiantes est)
        {
            return _connection.DeleteAsync(est);
        }
    }

}