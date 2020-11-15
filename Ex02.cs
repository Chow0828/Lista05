using System;

class MainClass {

  public struct Aluno{
    public string nome;
    public double nota1;
    public double nota2;
    public double media;
  }

  public static void Main (string[] args) {
    int qtd = 1;
    Aluno[] alunos = new Aluno[qtd];
    int x;
    for(x=0;x<qtd;x++){
      Console.Clear();
      Console.WriteLine("Digite o nome do {0}º aluno: ",x+1);
      alunos[x].nome = Console.ReadLine();
      Console.WriteLine("Digite a 1ª nota: ");
      alunos[x].nota1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a 2ª nota: ");
      alunos[x].nota2 = double.Parse(Console.ReadLine());
      alunos[x].media = (alunos[x].nota1 + alunos[x].nota2)/2;
    }
    Console.Clear();
    Console.WriteLine("Resultado final");
    Console.WriteLine("Aluno                 Nota1   Nota2   Média   Situação");
    for(x=0; x<qtd;x++){
      if(alunos[x].media >= 7){
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.WriteLine("{0,-21} {1,5:N2} {2,7:N2} {3,7:N2}   Aprovado",alunos[x].nome, alunos[x].nota1, alunos[x].nota2, alunos[x].media);
      }else{
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("{0,-21} {1,5:N2} {2,7:N2} {3,7:N2}   Reprovado",alunos[x].nome, alunos[x].nota1, alunos[x].nota2, alunos[x].media);
      }
    }

  }
}