using System;
using App_Cadastro_De_Series.View;
using App_Cadastro_De_Series.Class;
using App_Cadastro_De_Series.Class.TiposGenero;
namespace App_Cadastro_De_Series.Controller{
    public class controllerSeries{
        static SerieRepositorio repositorio = new SerieRepositorio();
        public void ListarSeries(){
            var MensagemLista = new ListarOk();
            Console.Clear();
            MensagemLista.entrada();
            var lista= repositorio.Lista();
            if(lista.Count ==0){
                Console.Clear();
                MensagemLista.NaoTem();
                Console.WriteLine();
                MensagemLista.saida();
                Console.ReadLine();
                return;
            }
            Console.WriteLine();
            foreach (var serie in lista){
                Console.WriteLine("\t\t\t\t\t\t Código({0}): - {1}", serie.retornaId(), serie.retornaTitulo());
            }
            Console.WriteLine();
            MensagemLista.saida();
            Console.ReadLine();
        }
        public void InserirSerie(){
            var MensagemInserir= new InserirOk_AtualizarOk();
            MensagemInserir.entrada();
            foreach (int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\t\t Código({0}) - {1}",i, Enum.GetName(typeof(Genero),i));
            }
            MensagemInserir.Informacao1();
            int entradaGenero = int.Parse(Console.ReadLine());

            MensagemInserir.Informacao2();
            string entradaTitulo = Console.ReadLine();

            MensagemInserir.Informacao3();
            int entradaAno = int.Parse(Console.ReadLine());

            MensagemInserir.Informacao4();
            string entradaDescricao = Console.ReadLine();
            MensagemInserir.Saida();

            Serie novaSerie = new Serie(id: repositorio.ProximoID(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }
        public void AtualizaSerie(){
            var MensagemAtualizar= new InserirOk_AtualizarOk();
            MensagemAtualizar.entrada2();
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("\t\t\t\t\t\t Código({0}) - {1}",i,Enum.GetName(typeof(Genero),i));
            }
            MensagemAtualizar.Informacao1();
            int entradaGenero = int.Parse(Console.ReadLine());

            MensagemAtualizar.Informacao2(); 
            string entradaTitulo = Console.ReadLine();

            MensagemAtualizar.Informacao3();
            int entradaAno = int.Parse(Console.ReadLine());

            MensagemAtualizar.Informacao4();
            string entradaDescricao = Console.ReadLine();

            MensagemAtualizar.Saida();
            Serie atualizaSerie= new Serie(id: indiceSerie,
                                          genero: (Genero)entradaGenero,
                                          titulo:entradaTitulo,
                                          ano: entradaAno,
                                          descricao: entradaDescricao);
            repositorio.Atualiza(indiceSerie,atualizaSerie);
        }
        public void ExcluiSerie(){
            var MensagemExcluir = new ExcluirOk();
            var MensagemLista = new ListarOk();
            var lista= repositorio.Lista();

            Console.Clear();
            MensagemExcluir.entrada();
            if(lista.Count ==0){
                Console.Clear();
                MensagemLista.NaoTem();
                Console.WriteLine();
                Console.ReadLine();
                return;
            }
            Console.WriteLine();
            foreach (var serie in lista){
                Console.WriteLine("\t\t\t\t\t\tCódigo({0}): - {1}", serie.retornaId(), serie.retornaTitulo());
            }
            MensagemLista.Linha();
            MensagemExcluir.qualSerie();
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
            MensagemExcluir.exclusao();
        }
        public void VisualizarSerie(){
            // mensagem perguntadno o id da serie
            var MensagemVisuSerie= new VerSerieOK();
            MensagemVisuSerie.entrada();
            MensagemVisuSerie.qualSerie();
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine("\t\t\t\t\t\t{}",serie);
            MensagemVisuSerie.Saida();
            Console.ReadLine();

        }

    }
}