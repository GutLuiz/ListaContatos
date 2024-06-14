using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.infraestrutura
{
    public class Conexaobd : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public Conexaobd()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=ListaDeContato;User id=postgres;Password=root;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
