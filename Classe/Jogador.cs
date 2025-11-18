namespace TrabalhoATP_Tetris.Classes
{
    public class Jogador
    {
        public string nome;
        public int pontuacaoFinal;

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
