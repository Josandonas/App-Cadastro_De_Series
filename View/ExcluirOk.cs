using System;
namespace App_Cadastro_De_Series.View{
    public class ExcluirOk{
        public void entrada(){
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t*      Exclusão De Serie         *");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t**********************************");
        }
        public void qualSerie(){
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tDigite o Código da Série:  ");
            Console.Write("\t\t\t\t\t\t");
        }
        public void exclusao(){
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t*      Exclusão Bem Sucedida     *");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.ReadLine();
        }
    }
}