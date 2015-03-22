using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente> ,IClienteService
    {
        private readonly IRepositoryCliente _repositoryCliente;

        public ClienteService(IRepositoryCliente repositoryCliente)
            : base(repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
