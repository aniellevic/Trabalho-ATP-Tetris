using System;

namespace TrabalhoATP_Tetris.Classes
{
    public class Tabuleiro
    {
        public int[,] matriz = new int[20, 10];

        // Construtor: inicializa todo o tabuleiro com zeros (vazio)
        public Tabuleiro()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = 0;
                }
            }
        }

         // Verifica se a peça pode ser inserida no tabuleiro
        public bool PodeInserir(Peca peca)
        {
            return false; // temporário
        }

        // Insere uma nova peça no topo do tabuleiro
        public void InserirPeca(Peca peca)
        {
        }

        // Remove a peça da sua posição atual na matriz
        public void Limpar(Peca peca)
        {
        }

        // Atualiza a posição da peça na matriz
        public void Atualizar(Peca peca)
        {
        }

        // Verifica linhas completas e remove
        public void VerificarLinhas(Peca peca)
        {
        }


        // Renderiza (desenha) o tabuleiro no console.
        public void Renderizar()
        {
            Console.Clear(); // limpa a tela a cada atualização
            string margem = "          ";
            Console.WriteLine(margem + "           TETRIS");
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(margem);
                Console.Write("|"); // borda esquerda

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Se a posição estiver vazia, imprime ponto
                    // Se estiver ocupada, imprime #
                   if (matriz[i, j] == 0)
                    Console.Write(". ");
                else
                    Console.Write("# ");
                }

                Console.WriteLine(" |"); // borda direita
            }

            
        }
    }
}
