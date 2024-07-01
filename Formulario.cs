using Contatos.infraestrutura;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
     public class Formulario
    {
        //Encapsulando
        public int Concodigo { get;  set; }
        public string Nome {  get;   set; }
        public string Empresa { get;  set; }
        public string Numero1  {  get;   set; }
        public string Numero2 {  get;   set; }
        public string Fixo1 {  get;   set; }
        public string Fixo2 {  get;   set; }

        public Formulario() { }

        // Fazendo um construtor com if (se nome estiver vazio lança uma exceção)
        public Formulario( string nome, string empresa, string numero1, string numero2, string fixo1, string fixo2)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatorio!");
            }
            Nome = nome;
            Empresa = empresa;
            Numero1 = numero1;
            Numero2 = numero2;
            Fixo1 = fixo1;
            Fixo2 = fixo2;
        }

       public static DataTable ObterContatos()
        {
            var dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Empresa", typeof(string));
            dt.Columns.Add("Numero1", typeof(string));
            dt.Columns.Add("Numero2", typeof(string));
            dt.Columns.Add("Fixo1", typeof(string));
            dt.Columns.Add("Fixo2", typeof(string));

            var repository = new ContatoRepositorio();
            var contatos = repository.Get();

            foreach (var contato in contatos)
            {
                dt.Rows.Add(contato.Nome, contato.Empresa, contato.Numero1, contato.Numero2, contato.Fixo1, contato.Fixo2);
            }


            return dt;
        }
    }
}
