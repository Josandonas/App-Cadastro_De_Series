using System.Collections.Generic;
namespace App_Cadastro_De_Series.Model{
    public interface IRespositorio<T>{
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
    }
}