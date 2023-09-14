using FiapStoreMinimalApi.Entidade;
using FiapStoreMinimalApi.Interface;

namespace FiapStoreMinimalApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IList<Usuario> _usuarios = new List<Usuario>();
        private string DataEHoraCriacao { get; set; }
        public UsuarioRepository()
        {
            DataEHoraCriacao = DateTime.Now.ToString();

            Console.WriteLine("Criacao Usuario: " + DataEHoraCriacao);
        }

        public IList<Usuario> ObterTodosUsuarios()
        {
            return _usuarios;
        }

        public Usuario ObterUsuarioPorId(int id)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Id == id);

            return usuario == null ? new Usuario() : usuario;
        }
        public void CadastrarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
        public void AlterarUsuario(Usuario usuario)
        {
            var usuarioParaAlterar = ObterUsuarioPorId(usuario.Id);

            if (usuarioParaAlterar != null)
                usuarioParaAlterar.Nome = usuario.Nome;

        }

        public void DeletarUsuario(int id)
        {
            _usuarios.Remove(ObterUsuarioPorId(id));
        }


    }
}
