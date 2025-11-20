using TrabalhoATP_Tetris.Classes;

namespace TrabalhoATP_Tetris
{
    public class Jogo
    {
        public Tabuleiro tabuleiro;
        public Jogador jogador;
        public Peca pecaAtual;

        // Construtor: inicia o tabuleiro
        public Jogo()
        {
            tabuleiro = new Tabuleiro();
        }

        public void Iniciar()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo ao Tetris");
            Console.Write("Digite seu nome: ");
            string nomeJogador = Console.ReadLine();
            jogador = new Jogador(nomeJogador);

            Console.WriteLine($"\nOlá, {nomeJogador}! Preparando o tabuleiro...");
            Console.WriteLine("Pressione qualquer tecla para começar...");

            bool jogoAtivo = true;

            // Loop principal
            while (jogoAtivo)
            {
                // Por enquanto, apenas renderiza o tabuleiro vazio:
                tabuleiro.Renderizar();

                // - gerar peça
                // - inserir peça
                // - mover peça
                // - verificar linhas
                // - atualizar pontuação
                // - detectar fim do jogo

                jogoAtivo = false; // TEMPORÁRIO – apenas evita loop infinito

            }

            Console.WriteLine("\nJogo encerrado!");

        }
    }
}
