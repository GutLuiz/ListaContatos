using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos.infraestrutura
{
    public class ContatoRepositorio
    {   // METODO PARA ADICIONAR NO BANCO DE DADOS
        public bool Add(Formulario formulario)  
        {
            using var conn = new Conexaobd();

            String query = @"INSERT INTO public.""Contatos""(
	connome, conempresa, concelular1, concelular2, confixo1, confixo2)
	VALUES (@nome, @empresa, @numero1, @numero2, @fixo1, @fixo2 );";

            var result = conn.Connection.Execute(sql: query, param: formulario);

            return result == 1;
        }

        // METODO PARA REMOVER DA LISTA E DO BANCO DE DADOS
        public void Remover(string nome)
        {
            using var conn = new Conexaobd();

            string query = @"DELETE FROM public.""Contatos"" WHERE connome = @Nome;";
            conn.Connection.Execute(sql: query, param: new { Nome = nome });
        }

        // METODO PARA MOSTRAR OS DADOS NA LISTA
        public List<Formulario> Get()
        {
            try
            {
                using var conn = new Conexaobd();

                string query = @"SELECT connome AS Nome, conempresa AS Empresa, 
                         concelular1 AS Numero1, concelular2 AS Numero2, 
                         confixo1 AS Fixo1, confixo2 AS Fixo2 
                         FROM public.""Contatos"";";

                var formularios = conn.Connection.Query<Formulario>(sql: query);
                return formularios.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter dados: {ex.Message}");
                return new List<Formulario>();
            }
        }

        // METODO PARA DESCOBRIR SE EXISTE UM DADO NA LISTA
        public bool ExisteFormulario(string nome, string empresa, string numero1)
        {
            using var conn = new Conexaobd();

            string query = @"SELECT COUNT(*) FROM ""Contatos"" 
                     WHERE connome = @Nome OR conempresa = @Empresa OR concelular1 = @Numero1";

            var parameters = new { Nome = nome, Empresa = empresa, Numero1 = numero1 };

            int count = conn.Connection.QuerySingle<int>(sql: query, param: parameters);

            return count > 0;
        }

    }

}
