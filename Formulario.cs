using System;
using System.Collections.Generic;
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

        // Fazendo um construtor com if (se nome  ou numero 1 estiver vazio lança uma exceção)
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
    }
}
