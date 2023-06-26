﻿using eCommerce.API.Models;
using System;
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
            var usuarios = new List<Usuario>();

            try
            {
                var command = new SqlCommand();
                command.CommandText = "SELECT * FROM Usuarios";
                command.Connection = (SqlConnection)_connection;

                _connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var usuario = new Usuario();

                    usuario.Id = dataReader.GetInt32("Id");
                    usuario.Nome = dataReader.GetString("Nome");
                    usuario.Email = dataReader.GetString("Email");
                    usuario.Sexo = dataReader.GetString("Sexo");
                    usuario.RG = dataReader.GetString("RG");
                    usuario.CPF = dataReader.GetString("CPF");
                    usuario.NomeMae = dataReader.GetString("NomeMae");
                    usuario.SituacaoCadastro = dataReader.GetString("SituacaoCadastro");
                    usuario.DataCadastro = dataReader.GetDateTimeOffset(8);

                    usuarios.Add(usuario);
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            finally 
            {
                _connection.Close();
            }

            return usuarios;
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
