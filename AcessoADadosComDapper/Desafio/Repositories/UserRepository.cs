using System;
using System.Collections.Generic;
using System.Linq;
using Blog.Models;
using Blog.Screens.UserScreens;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;

        public List<User> GetWithRoles()
        {
            var query = @"
                SELECT
                    [User].*,
                    [Role].*
                FROM
                    [User]
                    LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                    LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var users = new List<User>();

            var items = _connection.Query<User, Role, User>(
                query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr == null)
                    {
                        usr = user;
                        if (role != null)
                            usr.Roles.Add(role);

                        users.Add(usr);
                    }
                    else
                        usr.Roles.Add(role);

                    return user;
                }, splitOn: "Id");

            return users;
        }

        public void VincularUsuarioPerfil(int idRole, int idUser)
        {
            var query = "INSERT INTO UserRole (UserId,RoleId) VALUES (@UserId,@RoleId)";

            try
            {
                _connection.Query(query, new { UserId = idUser, RoleId = idRole });
                Console.WriteLine("Vínculo realizado com sucesso.");
                Console.ReadKey();
                LinkUserScreen.Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível víncular o usuário ao perfil - {ex.Message}");
                Console.ReadKey();
                LinkUserScreen.Load();
            }
        }
    }
}