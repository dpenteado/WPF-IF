using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropertiesWPF.Models
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorEstoque 
        { 
            get
            {
                return Preco * Quantidade;
            } 
        }

        public Produto(int codigo)
        {
            Codigo = codigo;
        }
    }
}
