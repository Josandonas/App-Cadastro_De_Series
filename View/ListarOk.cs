using System;
namespace App_Cadastro_De_Series.View{
    public class ListarOk{
        public void entrada(){
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t                                  ");
            Console.WriteLine("\t\t\t\t\t\t          Lista de Series         ");
            Console.WriteLine("\t\t\t\t\t\t                                  ");
            Console.WriteLine("\t\t\t\t\t\t**********************************");

        }
        public void saida(){
            Console.WriteLine("\t\t\t\t\t\t***********************************");
            Console.WriteLine("\t\t\t\t\t\t*                                 *");
            Console.WriteLine("\t\t\t\t\t\t***********************************");
        }
        public void NaoTem(){
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t*     Nenhuma Série Cadastrada   *");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t**********************************");
        }
        public void Linha(){
            Console.WriteLine("\t\t\t\t\t\t**********************************");
        }
    }
}