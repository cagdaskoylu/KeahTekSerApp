using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Database;
using KeahTekSerAppAPI.Repositories.BAKIM_ISTEK;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace KeahTekSerAppAPI.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseConnection _dataBaseConnection;
        public UserRepository(DatabaseConnection dataBaseConnection)
        {
            _dataBaseConnection = dataBaseConnection;
        }


        public async Task<List<PERSONEL_TABLOSU>> GetAll()
        {
            return await _dataBaseConnection.PERSONEL_TABLOSU.AsQueryable().ToListAsync();

        }

        public async Task<PERSONEL_TABLOSU> GetById(double personelSeq)
        {
            return await _dataBaseConnection.PERSONEL_TABLOSU.FirstOrDefaultAsync(x => x.PERSONEL_SEQ == personelSeq);
        }

        public async Task<PERSONEL_TABLOSU> FindByAsync(Expression<Func<PERSONEL_TABLOSU, bool>> predicate, bool trace = false)
        {
            return await _dataBaseConnection.PERSONEL_TABLOSU.AsNoTracking().SingleOrDefaultAsync(predicate);
        }

        public async Task<PERSONEL_TABLOSU> Login(PERSONEL_TABLOSU personel)
        {
            return await _dataBaseConnection.PERSONEL_TABLOSU.FirstOrDefaultAsync(x => x.PERSONEL_ID_NUMBER == personel.PERSONEL_ID_NUMBER);
        }
    }
}
