using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro__Produtos.Model
{
   public class Controle
    {
        private string nome;
        private int quantidade;
        private float valor;
        private string descricao;

        public void setNome(string nome)
        { 
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public int getQuantidade()
        {
            return this.quantidade;
        }
        public void setValor(float valor)
        {
            this.valor = valor;
        }
        public float getValor()
        {
            return this.valor;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        private salvar();
        

        } 

    }

