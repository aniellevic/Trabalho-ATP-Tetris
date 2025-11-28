using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Trabalho_ATP
{
    internal class Jogador
    {
        public string nome { get; private set; }
        public int pontuacaoFinal { get; private set; }
        public Jogador(string nome)
        {
            this.nome = nome;
            pontuacaoFinal = 0;
        }

        public void AdicionarPontos(int pontos)
        {
            pontuacaoFinal += pontos;
        }

        public void Salvar(string caminho)
        {
            try
            {
                StreamWriter arq = new StreamWriter(caminho, true, Encoding.UTF8);
                arq.WriteLine(nome + ":" + pontuacaoFinal);
                arq.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao salvar pontuação: " + e.Message);
            }
        }
    }
}
