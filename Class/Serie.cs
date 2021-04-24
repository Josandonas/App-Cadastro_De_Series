using System;
using App_Cadastro_De_Series.Class.TiposGenero;
namespace App_Cadastro_De_Series.Class{
    public class Serie : EntidadeBase{
        public Serie(Genero genero, string titulo, string desccricao, int ano){
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = desccricao;
            this.Ano = ano;

        }
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido{get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString(){
            string retorno = "";
            retorno += "Genero: "  + this.Genero + Environment.NewLine;
            retorno += "Titulo: "  + this.Titulo + Environment.NewLine;
            retorno += "Descricão: "  + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: "  + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public String retornaTitulo(){
            return this.Titulo;
        }
        public int retornaId(){
            return this.Id;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }
}