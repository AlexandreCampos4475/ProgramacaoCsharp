
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        //Nome e sobrenome juntos
        Console.WriteLine ("Qual o seu nome");
        string primeiroNome = Console.ReadLine();
        
         Console.WriteLine ("Qual o seu Sobrenome");
        string sobrenome = Console.ReadLine();
        
        Console.WriteLine("Seu nome completo e :"+ primeiroNome + " " +sobrenome);
        // imprimindo um int digitado pelo usuario
         Console.WriteLine ("Digite um numero");
     int numero = Convert.ToInt32(Console.ReadLine());
     
     Console.WriteLine("Seu numero e : "+numero);
     
     //calculando a idade pelo ano de nascimento
     Console.WriteLine ("Digite seu ano de nascimento");
        int anoNascimento = Convert.ToInt32(Console.ReadLine());
        
        int anoAtual = DateTime.Now.Year;
        
        
        int idade = anoAtual - anoNascimento;
        
             Console.WriteLine("Voce tem : "+idade + " anos");
        
        //Numero par ou imṕar
        
        
           Console.WriteLine ("Digite um numero");
        int numeros= Convert.ToInt32(Console.ReadLine());
        
        
        if(numeros%2 ==0){
            Console.WriteLine ("O numero " +numeros+ " e par");
            
        } else {
            Console.WriteLine ("O numero " +numeros+ " e impar");
        }
        
        // tabuada do numero
        
        
        Console.WriteLine ("Digite um numero: ");
        int num= Convert.ToInt32(Console.ReadLine());
        
        int num1 = num * 1;
         int num2 = num * 2;
          int num3 = num * 3;
           int num4 = num * 4;
            int num5 = num * 5;
             int num6 = num * 6;
              int num7 = num * 7;
               int num8 = num * 8;
                int num9 = num * 9;
                 int num10 = num * 10;
                 
     Console.WriteLine ("A tabuada do numero " +num+ " e:");
     Console.WriteLine ("Vezes 1: " +num1);
     Console.WriteLine ("Vezes 2: " +num2);
     Console.WriteLine ("Vezes 3; " +num3);
     Console.WriteLine ("Vezes 4: " +num4);
     Console.WriteLine ("Vezes 5: " +num5);
     Console.WriteLine ("Vezes 6: " +num6);
     Console.WriteLine ("Vezes 7: " +num7);
     Console.WriteLine ("Vezes 8: " +num8);
     Console.WriteLine ("Vezes 9: " +num9);
     Console.WriteLine ("Vezes 10: " +num10);
     
     
     // Soma de 2 numero - se for igual retorne o tiplo
     
         Console.WriteLine ("Digite um numero");
        int nume1= Convert.ToInt32(Console.ReadLine());
        
          Console.WriteLine ("Digite outro numero");
        int nume2= Convert.ToInt32(Console.ReadLine());
        
        
       
        
        
        if(nume1 == nume2){
            
            int somaTiplo = (nume1+nume2) * 3;
            Console.WriteLine ("Numeros sao iguais por isso ficou a soma do tiplo: "+somaTiplo );
            
        } else {
             int soma = nume1+ nume2;
            Console.WriteLine ("A soma e igual a: " + soma);
        }
     
        
        
    }
}system 