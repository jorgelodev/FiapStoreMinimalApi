using FiapStoreMinimalApi.Interface;

namespace FiapStoreMinimalApi.Repository
{
    public class UsaTodasRepository : IUsaTodasRepository
    {
        private ILivroRepository _livroRepository;
        private ICarrinhoRepository _carrinhoRepository;
        public UsaTodasRepository(ILivroRepository livroRepository, ICarrinhoRepository carrinhoRepository)
        {
            _livroRepository = livroRepository;
            _carrinhoRepository = carrinhoRepository;

        }

        public void VerificaDatas()
        {

        }
    }
}
