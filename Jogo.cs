using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ATP
{
    internal class Jogo
    {
        public Tabuleiro tabuleiro;
        public Jogador jogador;
        public Peca pecaAtual;
        private Random rnd = new Random();

        public Jogo()
        {
            tabuleiro = new Tabuleiro();
        }

        private Peca GerarPeca()
        {
            char[] tipos = { 'I', 'L', 'T' };
            return new Peca(tipos[rnd.Next(tipos.Length)]);
        }

        private bool TentarMover(int dx, int dy)
        {
            tabuleiro.Limpar(pecaAtual);
            pecaAtual.posX += dx;
            pecaAtual.posY += dy;
            if (!tabuleiro.PodeInserir(pecaAtual))
            {
                pecaAtual.posX -= dx;
                pecaAtual.posY -= dy;
                tabuleiro.Atualizar(pecaAtual);
                return false; 
            }
            tabuleiro.Atualizar(pecaAtual);
            return true;
        }
       
        private void RotacionarHorario()
        {
            tabuleiro.Limpar(pecaAtual);
            pecaAtual.RotacionarHorario();
            if (!tabuleiro.PodeInserir(pecaAtual))
                pecaAtual.RotacionarAntiHorario();
            tabuleiro.Atualizar(pecaAtual);
        }

        
        private void RotacionarAntiHorario()
        {
            tabuleiro.Limpar(pecaAtual);
            pecaAtual.RotacionarAntiHorario();
            if (!tabuleiro.PodeInserir(pecaAtual))
                pecaAtual.RotacionarHorario();
            tabuleiro.Atualizar(pecaAtual);
        }

        public void Iniciar()
        {
            Console.Clear();
            
            Console.WriteLine("\tOlá, bem vindo! ");
            Console.Write("Digite seu nome: ");
            jogador = new Jogador(Console.ReadLine());
            Console.WriteLine($"\nJogador {jogador.nome}, o jogo ira começar!");
            Console.WriteLine("\nAperta Enter");
            Console.ReadLine();

            bool jogoAtivo = true;

            while (jogoAtivo)
            {
                pecaAtual = GerarPeca();
                tabuleiro.InserirPeca(pecaAtual);
                if (!tabuleiro.PodeInserir(pecaAtual))
                {
                    Console.WriteLine("Não tem mais espaço! FIM DE JOGO!");
                    jogoAtivo = false;
                }

                tabuleiro.Atualizar(pecaAtual);
                bool descendo = true;

                while (descendo)
                {
                    tabuleiro.Renderizar();
                    Console.WriteLine("\n← → ↓   |   A = anti-horário   |   H = horário   |   S = sair");

                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.S)
                    {
                        descendo = false;
                        jogoAtivo = false;
                        continue;
                    }
                    if (tecla.Key == ConsoleKey.LeftArrow)
                        TentarMover(0, -1);
                    else if (tecla.Key == ConsoleKey.RightArrow)
                        TentarMover(0, 1);
                    else if (tecla.Key == ConsoleKey.DownArrow)
                    {
                        bool moved = TentarMover(1, 0);
                        if (!moved)
                            descendo = false;
                    }
                    else if (tecla.Key == ConsoleKey.A)
                        RotacionarAntiHorario();
                    else if (tecla.Key == ConsoleKey.H)
                        RotacionarHorario();
                }
                tabuleiro.VerificarLinhas(pecaAtual);

                int linhasRem = tabuleiro.UltimasLinhasRemovidas;
                jogador.AdicionarPontos(pecaAtual.pontos);

                if (linhasRem > 0)
                    jogador.AdicionarPontos(linhasRem * 300);
            }
            Console.WriteLine($"\nJogador {jogador.nome} fez {jogador.pontuacaoFinal} pontos!");
            jogador.Salvar("pontuacoes.txt");
        }
    }
}
