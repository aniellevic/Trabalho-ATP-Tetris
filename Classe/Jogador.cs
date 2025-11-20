namespace TrabalhoATP_Tetris.Classes
{
    public class Jogador
    {
        // Nome do jogador
        public string nome { get; private set; }

        // Pontuação final obtida durante a partida
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
            
        }
    }
}
