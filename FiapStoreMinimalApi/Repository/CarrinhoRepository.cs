using FiapStoreMinimalApi.Interface;

namespace FiapStoreMinimalApi.Repository
{
    public class CarrinhoRepository : ICarrinhoRepository
    {
        private string DataEHoraCriacao { get; set; }

        public CarrinhoRepository()
        {
            DataEHoraCriacao = DateTime.Now.ToString();

            Console.WriteLine("Criacao Carrinho: " + DataEHoraCriacao);
        }
    }
}
