using System;
using App_Cadastro_De_Series.View;
using App_Cadastro_De_Series.Controller;
namespace App_Cadastro_De_Series{
    class Decisao{
        public void decisao(){
            var Op = new Opcoes();
            string opcaoUsuario = Op.OpBase();
            var funcao = new controllerSeries();
            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        funcao.ListarSeries();
                        break;
                    case "2":
                        funcao.InserirSerie();
                        break;
                    case "3":
                        funcao.AtualizaSerie();
                        break;
                    case "4":
                        funcao.ExcluiSerie();
                        break;
                    case "5":
                        funcao.VisualizarSerie();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = Op.OpBase(); 
            }
            Op.OpFinal();
        }
    }
}
