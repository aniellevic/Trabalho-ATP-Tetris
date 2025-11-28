using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ATP
{
    internal class Tabuleiro
    {
        public int[,] matriz = new int[20, 10];
        public int UltimasLinhasRemovidas { get; private set; }

        public Tabuleiro()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = 0;  
                }
            }
            UltimasLinhasRemovidas = 0; 
        }

        public bool PodeInserir(Peca peca)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (peca.forma[i, j] == 1)
                    {
                        int linha = peca.posX + i;
                        int coluna = peca.posY + j;

                        if (linha < 0 || linha >= 20 || coluna < 0 || coluna >= 10)
                            return false;

                        if (matriz[linha, coluna] == 1)
                            return false;
                    }
                }
            }
            return true; 
        }
        
        public void InserirPeca(Peca peca)
        {
            peca.posX = 0;                 
            peca.posY = (10 - 3) / 2;      
        }
         public void Limpar(Peca peca)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (peca.forma[i, j] == 1)
                    {
                        int linha = peca.posX + i;
                        int coluna = peca.posY + j;

                        if (linha >= 0 && linha < 20 && coluna >= 0 && coluna < 10)
                        {
                            matriz[linha, coluna] = 0;
                        }
                    }
                }
            }
        }
        public void Atualizar(Peca peca)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (peca.forma[i, j] == 1)
                    {
                        int linha = peca.posX + i;
                        int coluna = peca.posY + j;

                        if (linha >= 0 && linha < 20 && coluna >= 0 && coluna < 10)
                        {
                            matriz[linha, coluna] = 1; 
                        }
                    }
                }
            }
        }
        public void VerificarLinhas(Peca peca)
        {
            int removidas = 0;
            for (int i = 0; i < 20; i++)
            {
                bool cheia = true;
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        cheia = false;
                    }
                }

                if (cheia)
                {
                    removidas++;
                    for (int k = i; k > 0; k--)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            matriz[k, j] = matriz[k - 1, j];
                        }
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        matriz[0, j] = 0;
                    }
                }
            }

            UltimasLinhasRemovidas = removidas; 
        }
        public void Renderizar()
        {
            Console.Clear();
            string margem = "          ";

            Console.WriteLine(margem + "\t TETRIS");
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write(margem + "|"); 

                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] == 1 ? "# " : "  ");
                }

                Console.WriteLine("|"); 
            }
        }
    }
}