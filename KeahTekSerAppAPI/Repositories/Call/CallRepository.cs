using AutoMapper;
using KeahTekSerAppAPI.Database;
using KeahTekSerAppAPI.Database.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.Repositories.BAKIM_ISTEK
{
    public class CallRepository : ICallRepository
    {
        private readonly DatabaseConnection _dataBaseConnection;
        public CallRepository(DatabaseConnection dataBaseConnection)
        {
            _dataBaseConnection = dataBaseConnection;
        }


        public async Task<CIHAZ_BAKIM> PostCb(CIHAZ_BAKIM cb)
        {
            _dataBaseConnection.CIHAZ_BAKIM.Add(cb);
            await _dataBaseConnection.SaveChangesAsync();
            return cb;
        }

        public async Task<CIHAZ_BAKIM_ISTEK> Put(CIHAZ_BAKIM_ISTEK istek)
        {
            _dataBaseConnection.CIHAZ_BAKIM_ISTEK.Update(istek);
            await _dataBaseConnection.SaveChangesAsync();   
            return istek;
        }

        public async Task<CIHAZ_BAKIM_ISTEK> GetDetailBySeq(double seq)
        {
            return await _dataBaseConnection.CIHAZ_BAKIM_ISTEK.FirstOrDefaultAsync(x => x.CIHAZ_BAKIM_ISTEK_SEQ == seq);

        }

        public async Task<List<CIHAZ_BAKIM_ISTEK>> GetByPersonelSeq(double personelSeq)
        {
            return await _dataBaseConnection.CIHAZ_BAKIM_ISTEK.AsQueryable().Where(x => x.CBI_YOLLANAN_PER == personelSeq).ToListAsync();
        }

        public async Task<List<CIHAZ_BAKIM_ISTEK>> GetUnreponsedCallsByPersonelSeq(double personelSeq)
        {
            return await _dataBaseConnection.CIHAZ_BAKIM_ISTEK.AsQueryable().Where(x=> x.CBI_YOLLANAN_PER == personelSeq && (x.STATU =="Cevaplanmadı" || x.STATU == "Yönlendirildi")).ToListAsync();
        }

        public async Task<CIHAZ_BAKIM_ISTEK> FindByAsync(Expression<Func<CIHAZ_BAKIM_ISTEK, bool>> predicate, bool trace = false)
        {
            return await _dataBaseConnection.CIHAZ_BAKIM_ISTEK.AsNoTracking().SingleOrDefaultAsync(predicate);
        }

        public async Task<CIHAZ_BAKIM_ISTEK> Forward(CIHAZ_BAKIM_ISTEK istek)
        {
            _dataBaseConnection.CIHAZ_BAKIM_ISTEK.Update(istek);
            await _dataBaseConnection.SaveChangesAsync();
            return istek;
        }

        public async Task<CIHAZ_BAKIM_YONLENDIRME> YonlendirmeDetay(CIHAZ_BAKIM_YONLENDIRME yonlendirme)
        {
            _dataBaseConnection.CIHAZ_BAKIM_YONLENDIRME.Add(yonlendirme);
            await _dataBaseConnection.SaveChangesAsync();
            return yonlendirme;
        }

        public async Task<CIHAZ_BAKIM_SEBEBI> CihazBakimSebebi(int sebepId)
        {
            return await _dataBaseConnection.CIHAZ_BAKIM_SEBEBI.FirstOrDefaultAsync(x => x.BAKIM_SEBEBI_SEQ == sebepId);
        }
    }
}
