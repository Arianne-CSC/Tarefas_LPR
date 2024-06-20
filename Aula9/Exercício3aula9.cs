using System;
class HelloWorld {
    
    public struct Heroi{
        public string Nome;
        public string Poder;
        public int Pontuacao;

        public void cadastrarHeroi(){
            Console.WriteLine("Insira o nome de um Heroi");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o poder desse Heroi");
            string poder = Console.ReadLine();
            Console.WriteLine("Insira a pontuacao desse Heroi");
            int pontuacao = Convert.ToInt32(Console.ReadLine());
            Nome = nome;
            Poder = poder;
            Pontuacao = pontuacao;
        }
    }
    
    public struct Equipe{
        public Heroi[] herois;

        public void selecionarEquipe(Heroi[] opcoes){
            herois = new Heroi[3];
            Console.WriteLine("Opções:");
            Console.WriteLine("0 - "+opcoes[0].Nome);
            Console.WriteLine("1 - "+opcoes[1].Nome);
            Console.WriteLine("2 - "+opcoes[2].Nome);
            Console.WriteLine("3 - "+opcoes[3].Nome);
            Console.WriteLine("4 - "+opcoes[4].Nome);

            for(int i=0;i<herois.Length;i++){
                int val = i+1;
                int posHeroi;
                Console.WriteLine("Digite o "+(val)+"º Heroi");
                posHeroi = Convert.ToInt32(Console.ReadLine());
                herois[i] = opcoes[posHeroi];
            }
        }
        
        public void exibirEquipe(){
            for(int i=0; i<herois.Length;i++){
                Console.WriteLine($"Heroi: {herois[i].Nome} - Poder: {herois[i].Poder}");
            }
            Console.WriteLine($"Pontuacao Total: {calcularPontuacaoTotal()}");
        }

        public int calcularPontuacaoTotal(){
            int pontucaoTotal =0;
            for(int i=0; i<herois.Length;i++){
                pontucaoTotal = pontucaoTotal + herois[i].Pontuacao;
            }
            return pontucaoTotal;
        }
    }

  static void Main() {
    Heroi[] opcoes_herois = new Heroi[5];
    Equipe equipe = new Equipe();
    int opcoes=1;
    bool equipeSelecionada = false;
    bool heroisCadastrados = false;
    while(opcoes != 0){
        Console.WriteLine("Selecione umas das Opções:");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Cadastro de Herois");
        Console.WriteLine("2 - Seleção de Equipe");
        Console.WriteLine("3 - Exibição da Equipe");
        opcoes = Convert.ToInt32(Console.ReadLine());
        if(opcoes == 1){
            for(int i=0;i<opcoes_herois.Length;i++){
                opcoes_herois[i].cadastrarHeroi();
            }
            heroisCadastrados = true;
        }
        else if(opcoes == 2){
            if(heroisCadastrados == true){
                equipe.selecionarEquipe(opcoes_herois);
                equipeSelecionada = true;
            }
            else{
                Console.WriteLine("Cadastre os Herois Primeiro");
            }
        }
        else if(opcoes == 3){
            if(equipeSelecionada == true){
                equipe.exibirEquipe();
            }
            else{
                Console.WriteLine("Selecione sua equipe Primeiro");
            }
        }
    }
  }
}