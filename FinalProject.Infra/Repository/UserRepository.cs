using FinalProject.Core.Common;
using FinalProject.Core.Data;
using FinalProject.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FinalProject.Infra.Common;
using Dapper;

namespace FinalProject.Infra.Repository
{
    public class UserRepository :IUserRepository
    {
        private readonly IDbContext dbContext;
        public UserRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<User> GetAllUsers()
        {
            IEnumerable<User> users = dbContext.Connection.Query<User>("User_P.GetAllUsers",commandType: CommandType.StoredProcedure);
            return users.ToList();
        }
        public void CreateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("firstname", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lastname", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("gender", user.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("imagepath", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("accepts", user.Isaccepted, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("roleid", user.RoleidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("User_P.CreateUser", p, commandType: CommandType.StoredProcedure);
        }
        public void UpdateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("id", user.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("fname", user.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("lname", user.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pword", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("eml", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("gen", user.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("img", user.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("phone", user.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("accepts", user.Isaccepted, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("rolee", user.RoleidFk, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("usname", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("User_P.UpdateUser", p, commandType: CommandType.StoredProcedure);
        }
        public User UserGetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<User> users = dbContext.Connection.Query<User>("User_P.getuserbyid",p, commandType: CommandType.StoredProcedure);
            return users.FirstOrDefault();

        }
        public void DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("User_P.DeleteUser", p, commandType: CommandType.StoredProcedure);
        }


    }
}
