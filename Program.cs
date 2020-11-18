using System;

namespace Backend_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {   
            string refazer = "sim";
            while(refazer == "sim"){

                
                Console.WriteLine("-------------------------------------------------");
           
                Console.WriteLine("Eae,eu sou sua tabua em forma de C# =)");
               
                Console.WriteLine("-------------------------------------------------");
                System.Threading.Thread.Sleep(700);

                Console.Write("Qual tabuada você quer ver?");
           
                Console.WriteLine(" (apenas números)");
               
                int tabuada = int.Parse(Console.ReadLine());
                Console.WriteLine("");
             
                System.Threading.Thread.Sleep(700);
                Console.WriteLine($"A tabuada de {tabuada} é:");

                int resultado = 0;
            
                for(int contador = 0; contador <= 10; contador++){
                    resultado = tabuada * contador;
                  
                    Console.Write($"{tabuada} x {contador} = ");
                
                    Console.WriteLine(resultado);

                    System.Threading.Thread.Sleep(850);
                }

                Console.WriteLine("");
              
                Console.WriteLine("Ta afim de fazer outra a operação?");
                System.Threading.Thread.Sleep(500);
         
                refazer = Console.ReadLine();

                if(refazer != "sim"){
                    System.Threading.Thread.Sleep(650);
                    Console.WriteLine("");
         
                    Console.WriteLine("Valeu a preferência =)");
                }
                
            }
        }
    }
}
