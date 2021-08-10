using LibrosLeidos.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosLeidos.Data
{
    class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LibrosLeidosLinnette;Data Source=LAPTOP-VB5HIN48\\SQLEXPRESS");

        public void InsertarLibro(ClsIngresoDatos insertar)
        {
            try
            {
                conn.Open();
                string query = @"
                                INSERT INTO Libros (numero_id_ano, nombre_libro, nombre_autor, saga_serie_trilogia, numero_saga, ano_leido)
                                VALUES (@numero_id_ano, @nombre_libro, @nombre_autor, @saga_serie_trilogia, @numero_saga, @ano_leido)";

                SqlParameter numeroIdAno = new SqlParameter("@numero_id_ano", insertar.numero_id_ano);
                SqlParameter nombreLibro = new SqlParameter("@nombre_libro", insertar.nombre_libro);
                SqlParameter nombreAutor = new SqlParameter("@nombre_autor", insertar.nombre_autor);
                SqlParameter sagaSerieTrilogia = new SqlParameter("@saga_serie_trilogia", insertar.saga_serie_trilogia);
                SqlParameter numeroSaga = new SqlParameter("@numero_saga", insertar.numero_saga);
                SqlParameter anoLeido = new SqlParameter("@ano_leido", insertar.ano_leido);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(numeroIdAno);
                command.Parameters.Add(nombreLibro);
                command.Parameters.Add(nombreAutor);
                command.Parameters.Add(sagaSerieTrilogia);
                command.Parameters.Add(numeroSaga);
                command.Parameters.Add(anoLeido);

                command.ExecuteNonQuery();

                MessageBox.Show("Libro ingresado de manera correcta", "Libro ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<ClsIngresoDatos> ObtenerLibros()
        {
            List<ClsIngresoDatos> libros = new List<ClsIngresoDatos>();

            try
            {
                conn.Open();
                string query = @"SELECT numero_id_ano, nombre_libro, nombre_autor, saga_serie_trilogia, numero_saga, ano_leido FROM Libros ORDER BY ano_leido desc, numero_id_ano desc";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    libros.Add(new ClsIngresoDatos
                    {
                        numero_id_ano = int.Parse(reader["numero_id_ano"].ToString()),
                        nombre_libro = reader["nombre_libro"].ToString(),
                        nombre_autor = reader["nombre_autor"].ToString(),
                        saga_serie_trilogia = reader["saga_serie_trilogia"].ToString(),
                        numero_saga = Double.Parse(reader["numero_saga"].ToString()),
                        ano_leido = int.Parse(reader["ano_leido"].ToString())

                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return libros;
        }
    }
}
