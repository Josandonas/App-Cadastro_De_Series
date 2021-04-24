using System;
namespace App_Cadastro_De_Series.View{
    public class Opcoes{
        public string OpBase(){
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t*       Series LoopVisual        *");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.WriteLine("\t\t\t\t\t\t*  Informe a opção desejada:     *");
            Console.WriteLine("\t\t\t\t\t\t*                                *");            
            Console.WriteLine("\t\t\t\t\t\t*  1- Listar Séries              *");
            Console.WriteLine("\t\t\t\t\t\t*  2- Inserir Nova Série         *");
            Console.WriteLine("\t\t\t\t\t\t*  3- Atualizar Série            *");
            Console.WriteLine("\t\t\t\t\t\t*  4- Excluir Série              *");
            Console.WriteLine("\t\t\t\t\t\t*  5- Visualizar Série           *");
            Console.WriteLine("\t\t\t\t\t\t*  X- Sair                       *");
            Console.WriteLine("\t\t\t\t\t\t*                                *");
            Console.WriteLine("\t\t\t\t\t\t**********************************");
            Console.Write("\t\t\t\t\t\t");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        public void OpFinal(){
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t*****************************************");
            Console.WriteLine("\t\t\t\t\t\t*                                       *");
            Console.WriteLine("\t\t\t\t\t\t*  Obrigado Pelo Uso De Nossos Serviços *");
            Console.WriteLine("\t\t\t\t\t\t*                                       *");
            Console.WriteLine("\t\t\t\t\t\t*****************************************");
            
        }
    }
}