using System;

class MainClass {

  public struct Carro{
    public string modelo;
    public string cor;
    public int ano;
  }

  public static void Main (string[] args) {
    int qtd = 500;
    Carro[] carros = new Carro[qtd];
    int opcao=0, total=0, anoProcura, x, cod=0;
    string procurado;
    do{
      Console.Clear();
      Console.WriteLine("Menu \n1-Cadastrar\n2-Consultar por ano\n3-Consultar por modelo\n4-Consultar por cor\n5-Exibir todos\n6-Alterar\n7-Excluir\n0-Sair");
      opcao = int.Parse(Console.ReadLine());
      Console.Clear();
      switch(opcao){
        case 1:
          Console.WriteLine("Cadastro de Carro");
          if(total<qtd){
            Console.WriteLine("Ano: ");
            carros[total].ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Cor: ");
            carros[total].cor = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            carros[total].modelo = Console.ReadLine();
            total++;
          }else{
            Console.WriteLine("Está cheio!");
          }
          break; 
        case 2:
          Console.WriteLine("Consulta por ano ");
          if(total>0){
            Console.WriteLine("Digite o ano procurado: ") ;
            anoProcura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ano    Modelo     Cor");
            for(x=0; x<total; x++){
              if(carros[x].ano == anoProcura){
                Console.WriteLine("{0}   {1,-10} {2,-20}",carros[x].ano, carros[x].modelo, carros[x].cor);
              }
            }
          }else{
            Console.WriteLine("Sem cadastros no momento");
          }
          Console.WriteLine("\n>>Tecle Enter para continuar.");
          Console.ReadLine();
          break;
        case 3:
          Console.WriteLine("Consultar por modelo");
          if(total>0){
            Console.WriteLine("Modelo procurado: ");
            procurado = Console.ReadLine();
            Console.WriteLine("Ano    Modelo     Cor");
            for(x=0; x<total; x++){
              if(carros[x].modelo.Equals(procurado)){
                Console.WriteLine("{0}   {1,-10} {2,-20}",carros[x].ano, carros[x].modelo, carros[x].cor);
              }
            }
          }else{
            Console.WriteLine("Sem cadastros no momento");
          }
           Console.WriteLine("\n>>Tecle Enter para continuar.");
          Console.ReadLine();
          break; 
        case 4:
          Console.WriteLine("Consultar por cor");
          if(total>0){
            Console.WriteLine("Modelo a cor procurada: ");
            procurado = Console.ReadLine();
            Console.WriteLine("Ano    Modelo     Cor");
            for(x=0; x<total; x++){
              if(carros[x].cor.Equals(procurado)){
                Console.WriteLine("{0}   {1,-10} {2,-20}",carros[x].ano, carros[x].modelo, carros[x].cor);
              }
            }
          }else{
            Console.WriteLine("Sem cadastros no momento");
          }
           Console.WriteLine("\n>>Tecle Enter para continuar.");
          Console.ReadLine();
          break;
        case 5:
          Console.WriteLine("Lista com todos os carros");
          if(total>0){            
            Console.WriteLine("Código Ano    Modelo     Cor");
            for(x=0; x<total; x++){
                Console.WriteLine("{0} {1}   {2,-10} {3,-20}", x, carros[x].ano, carros[x].modelo, carros[x].cor);
            }
          }else{
            Console.WriteLine("Sem cadastros no momento");
          }
           Console.WriteLine("\n>>Tecle Enter para continuar.");
          Console.ReadLine();
          break; 
        case 6:
          Console.WriteLine("Lista com todos os carros");
          if(total>0){            
            Console.WriteLine("Código Ano    Modelo     Cor");
            for(x=0; x<total; x++){
                Console.WriteLine("{0}) {1}   {2,-10} {3,-20}",x, carros[x].ano, carros[x].modelo, carros[x].cor);
            }
            Console.WriteLine("Digite o código do carro desejado:");
            cod = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Dados atuais:");
            Console.WriteLine("Código Ano    Modelo     Cor");
            Console.WriteLine("{0}) {1}   {2,-10} {3,-20}",cod, carros[cod].ano, carros[cod].modelo, carros[cod].cor);
            Console.WriteLine("Novos dados:");
            Console.WriteLine("Novo Ano: ");
            carros[cod].ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Nova Cor: ");
            carros[cod].cor = Console.ReadLine();
            Console.WriteLine("Novo Modelo: ");
            carros[cod].modelo = Console.ReadLine();
          }else{
            Console.WriteLine("Sem cadastros no momento");
          }
           Console.WriteLine("\n>> Tecle Enter para continuar.");
          Console.ReadLine();
          break;
        case 7:
          Console.WriteLine("Lista com todos os carros");
          if(total>0){            
            Console.WriteLine("Código Ano    Modelo     Cor");
            for(x=0; x<total; x++){
                Console.WriteLine("{0}) {1}   {2,-10} {3,-20}",x, carros[x].ano, carros[x].modelo, carros[x].cor);
            }
            Console.WriteLine("Digite o código do carro a ser excluido:");
            cod = int.Parse(Console.ReadLine());
            for(x=0; x<(total-1); x++){
              if(x >= cod){
                carros[x].cor = carros[x+1].cor;
                carros[x].modelo = carros[x+1].modelo;
                carros[x].ano = carros[x+1].ano;
              }
            }
            total--;

          }else{
            Console.WriteLine("Sem cadastros no momento");
          }
           Console.WriteLine("\n>> Tecle Enter para continuar.");
          Console.ReadLine();
          break;             
      }
    }while(opcao != 0);

  }
}