using eCommerce.API.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IDbConnection _connection;

        public UsuarioRepository()
        {
            _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=eCommerceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public List<Usuario> Get()
        {
            throw new System.NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
