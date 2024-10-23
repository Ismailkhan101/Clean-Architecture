using MedicalApp.Application.Comman.Interface;
using MedicalApp.Domain.Entities;
using MedicalApp.Infrastructure.Data;
using MedicalApp.Infrastructure.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MedicalAppDbContext _Db;

        public UserRepository(MedicalAppDbContext Db)
        {
            _Db = Db;
        }
        public void CreateAsync(User user)
        {
           _Db.Users.Add(user);
        }

        public async void DeleteAsync(int id)
        {
           var user=await _Db.Users.FindAsync(id);
           _Db.Users.Remove(user);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            try
            {
                return await _Db.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the error
                throw (ex);
            }
        }

       public User GetByIdAsync(int id)
        {
            return  _Db.Users
            .Where(u => u.Id==id).FirstOrDefault();
        }

       public void Save()
        {
            _Db.SaveChanges();
        }

        public void UpdateAsync(User user)
        {
            _Db.Users.Update(user);
        }
    }
}
