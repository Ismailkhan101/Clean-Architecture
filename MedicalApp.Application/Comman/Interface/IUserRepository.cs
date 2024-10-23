using MedicalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Application.Comman.Interface
{
    public interface IUserRepository
    {
        Task< IEnumerable<User>> GetAllAsync();
        User GetByIdAsync(int id);
        void CreateAsync(User user);
        void UpdateAsync(User user);
        void DeleteAsync(int id);
        void Save();   
    }
}
