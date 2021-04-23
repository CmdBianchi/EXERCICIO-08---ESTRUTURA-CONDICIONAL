using System;
namespace EXERCICIO_08___ESTRUTURA_CONDICIONAL{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Determine qual o quadrante ao qual pertence o ponto.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            double x, y;

            Console.Write("DIGITE A COORDENADA: ");
            x = int.Parse(Console.ReadLine());           
            Console.Write("DIGITE A COORDENADA: ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0){
                Console.WriteLine("Quadrante 1");
            }
            else if (x > 0 && y < 0){
                Console.WriteLine("Quadrante 2");
            }
            else if (x < 0 && y < 0){
                Console.WriteLine("Quadrante 3");
            }
            else if (x < 0 && y > 0){
                Console.WriteLine("INTERVALO Q4");
            }
            else{
                Console.WriteLine("FORA DO INTERVALO");
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
