using FiapStoreMinimalApi.Interface;

namespace FiapStoreMinimalApi.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private string DataEHoraCriacao { get; set; }
        public LivroRepository()
        {
            DataEHoraCriacao = DateTime.Now.ToString();

            Console.WriteLine("Criacao Livro: " + DataEHoraCriacao);
        }
    }
}
