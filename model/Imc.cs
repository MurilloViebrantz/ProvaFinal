using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace imc
{
    class ProvaFinal
    {
        static void Main(string[] args)
        {
         float A, P, imc;
    
            Console.Write("Digite o seu peso:");
            P =float.Parse(Console.ReadLine());


            Console.Write("Digite o seu altura:");
            A = float.Parse(Console.ReadLine());
      
            imc=(P /(A*A ));
            
              if(imc<18.5)
            {
                Console.WriteLine("Magresa");
            }
             else if ((imc ==18.5) || (imc  ==24.9))
            {
                Console.WriteLine("Normal");
            }
              if ((imc > 25) || (imc ==29.9))
 
            {
                Console.WriteLine("Sobrepeso I");
            }
              else if ((imc > 30) || (imc ==39.9))
            {
                Console.WriteLine("Obesidade II");
            }
              else if (imc ==40)
            {
                Console.WriteLine("Obesidade III");
            }
           
            
            Console.ReadKey();


        }
    }
}