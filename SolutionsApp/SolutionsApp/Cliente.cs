using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsApp
{
    class Cliente
    {
        public string usuario { get; set; }

        public string senha { get; set; }

        public Cliente(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
