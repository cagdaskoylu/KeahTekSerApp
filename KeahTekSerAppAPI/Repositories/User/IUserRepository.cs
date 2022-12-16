using KeahTekSerAppAPI.Database.Entites;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace KeahTekSerAppAPI.Repositories.User
{
    public interface IUserRepository
    {
        Task<List<PERSONEL_TABLOSU>> GetAll();
        Task<PERSONEL_TABLOSU> GetById(double personelSeq);
        Task<PERSONEL_TABLOSU> FindByAsync(Expression<Func<PERSONEL_TABLOSU, bool>> predicate, bool trace = false);
        Task<PERSONEL_TABLOSU> Login(PERSONEL_TABLOSU personel);
    }
}
