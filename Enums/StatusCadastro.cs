using System.ComponentModel;

namespace CrudProduto.Enums
{
    public enum StatusCadastro
    {
        [Description(" A fazer")]
        Afazer = 1,

        [Description(" Em andamento")]
        EmAndamento = 2,

        [Description(" Concluido")]
        Concluido = 3

    }
}
