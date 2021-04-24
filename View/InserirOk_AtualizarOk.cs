using System;
namespace App_Cadastro_De_Series.View{
    public class InserirOk_AtualizarOk{
       public void entrada() {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t                                  ");
            Console.WriteLine("\t\t\t\t\t\t   Cadastro de Nova Série         ");
            Console.WriteLine("\t\t\t\t\t\t                                  ");
            Console.WriteLine("\t\t\t\t\t\t**********************************");
       }
       public void entrada2() {
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t                                  ");
            Console.WriteLine("\t\t\t\t\t\t          Edição de Série         ");
            Console.WriteLine("\t\t\t\t\t\t                                  ");
            Console.WriteLine("\t\t\t\t\t\t**********************************");
       }
       public void Informacao1(){
            Console.WriteLine("\t\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t\tDigite o Código Da opção De Gênero Acima: ");
            Console.Write("\t\t\t\t\t\t");
       }
       public void Informacao2(){
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tDigite o Título Da Série: ");
            Console.Write("\t\t\t\t\t\t");
       }
        public void Informacao3(){
             Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tDigite o Ano De Início Da Série: ");
            Console.Write("\t\t\t\t\t\t");
       }
        public void Informacao4(){
             Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tDigite a Descrição da Série:  ");
            Console.Write("\t\t\t\t\t\t");
       }
       public void Saida(){
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t***********************************");
            Console.WriteLine("\t\t\t\t\t\t*                                 *");
            Console.WriteLine("\t\t\t\t\t\t***********************************");
       }
    }
}