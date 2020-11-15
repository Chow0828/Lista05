using System;

class MainClass {

  public struct Data{
    public int dia;
    public int mes;
    public int ano;
  }
  public static void Main (string[] args) {
    Data data;
    Boolean bissexto;
    Console.WriteLine("Digite o dia:");
    data.dia = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o mês:");
    data.mes = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano:");
    data.ano = int.Parse(Console.ReadLine());

    if(((data.ano % 4 == 0) && (data.ano % 100 !=0)) || data.ano % 400==0){
      bissexto = true;
    }else{
      bissexto = false;
    }
    if(data.dia < 1 || data.dia > 31 || 
        (data.dia >28 && data.mes == 2 && !bissexto) ||
        (data.dia >29 && data.mes == 2 && bissexto) ||
        (data.dia >30 && (data.mes == 4 || data.mes == 6 || data.mes == 9 || data.mes ==11)) ||
        (data.mes <1 || data.mes >12)){
          Console.WriteLine("Data inválida");

    }else{
      Console.WriteLine("Data válida!");
    }


  }
}