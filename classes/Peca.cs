using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_ATP
{
    internal class Peca
    {
        public int[,] forma;
        public int posX;
        public int posY;
        public char tipo;
        public int pontos;

        public Peca(char tipo)
        {
            this.tipo = tipo;
            forma = new int[3, 3]; 
            posX = 0; 
            posY = 0;
            if (tipo == 'I')
            {
                pontos = 3; 
                forma[0, 0] = 0; forma[0, 1] = 1; forma[0, 2] = 0;
                forma[1, 0] = 0; forma[1, 1] = 1; forma[1, 2] = 0;
                forma[2, 0] = 0; forma[2, 1] = 1; forma[2, 2] = 0;
            }

            else if(tipo == 'L')
            {
                pontos = 4;  
                forma[0, 0] = 1; forma[0, 1] = 1; forma[0, 2] = 1;
                forma[1, 0] = 1; forma[1, 1] = 0; forma[1, 2] = 0;
                forma[2, 0] = 1; forma[2, 1] = 0; forma[2, 2] = 0;
            }

            else if (tipo == 'T')  
            {
                pontos = 5; 
                forma[0, 0] = 1; forma[0, 1] = 1; forma[0, 2] = 1;
                forma[1, 0] = 0; forma[1, 1] = 1; forma[1, 2] = 0;
                forma[2, 0] = 0; forma[2, 1] = 1; forma[2, 2] = 0;
            }
        }
        public void RotacionarHorario()
        {
            int[,] nova = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    nova[i, j] = forma[2 - j, i];
                }
            }
            forma = nova; 
        }
        public void RotacionarAntiHorario()
        {
            {
                int[,] nova = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        nova[i, j] = forma[j, 2 - i];
                    }
                }
                forma = nova; 
            }
        }
        public void MoverEsquerda()
        {
            posY--;
        }
        public void MoverDireita()
        {
            posY++;
        }
        public void MoverBaixo()
        {
            posX++;
        }
    }
}