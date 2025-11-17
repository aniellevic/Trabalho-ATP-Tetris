namespace TrabalhoATP_Tetris.Classes
{
    public class Peca
    {
        public int[,] forma;
        public int posX;
        public int posY;
        public char tipo;
        public int pontos;

        public Peca(char tipo)
        {
        }

        public void RotacionarHorario()
        {
        }

        public void RotacionarAntiHorario()
        {
        }

        public void MoverEsquerda()
        {
        }

        public void MoverDireita()
        {
        }

        public void MoverBaixo()
        {
        }
    }
}

{
    public class Peca
    {
        public int[3,3] forma;
        public int posX;
        public int posY;
        public char tipo;
        public int pontos;

        public Peca(char tipo)
        {
            this.tipo = tipo;

            if (tipo == 'I')
            {
                forma = new int[,] {
                    {0,1,0},
                    {0,1,0},
                    {0,1,0}
                };
                pontos = 3;
            }
            else if (tipo == 'L')
            {
                forma = new int[,] {
                    {1,1,1},
                    {0,1,0},
                    {0,1,0}
                };
                pontos = 4;
            }
            else if (tipo == 'T')
            {
                forma = new int[,] {
                    {1,1,1},
                    {0,1,0},
                    {1,0,0}
                };
                pontos = 5;
            }

            posX = 0;
            posY = 0;
        }

        public void RotacionarHorario()
        {
        }

        public void RotacionarAntiHorario()
        {
        }

        public void MoverEsquerda()
        {
            posX--;
        }

        public void MoverDireita()
        {
            posX++;
        }

        public void MoverBaixo()
        {
            posY++;
        }
    }
}
