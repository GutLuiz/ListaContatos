//Importações a biblioteca Nqgsql e várias classes e metodos da biblioteca base do .NET
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Contatos.infraestrutura
{
    // Declara uma classe publica e uma interface "IDisposable, usada para liberar recursos não gerenciados
    public class Conexaobd : IDisposable
    {
        // Definindo uma propriedadde publica chamada "Connection" do tipo "NqgsqlConnection"
        public NpgsqlConnection Connection { get; set; }

        // Construtor que cria uma instacia com uma string de conexão forneciada, que especifica como se conectaar ao banco de dados PostgresSql, em seguida ele abre a conexão.
        public Conexaobd()
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=ListaDeContato;User id=postgres;Password=root;");
            Connection.Open();
        }

        // Implementa o metodo "Dispose" da interface "IDisposable", para liberar todos os recursos utilizados pela conexão com o banco de dados quando a instancia não for mais necessaria 
        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
