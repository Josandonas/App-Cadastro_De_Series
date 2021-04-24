using System;
using System.Collections.Generic;
using App_Cadastro_De_Series.Model;
namespace App_Cadastro_De_Series.Class{
    public class SerieRepositorio : IRespositorio<Serie>{
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto){
            listaSerie[id] = objeto;
        }

        public void Exclui(int id){
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto){
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista(){
            return listaSerie;
        }

        public int ProximoID(){
            return listaSerie.Count;
        }
        public Serie RetornaPorId(int id){
            return listaSerie[id];
        }
    }
}