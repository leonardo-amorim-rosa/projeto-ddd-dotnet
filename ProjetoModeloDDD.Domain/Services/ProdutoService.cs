using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ProdutoService(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _repositoryProduto.BuscarPorNome(nome);
        }
    }
}
