using KeahTekSerAppAPI.Database;
using KeahTekSerAppAPI.Database.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.Repositories.BAKIM_ISTEK
{
    public interface ICallRepository
    {
        Task<CIHAZ_BAKIM_ISTEK> GetDetailBySeq(double seq);
        Task<List<CIHAZ_BAKIM_ISTEK>> GetByPersonelSeq(double personelSeq);
        Task<List<CIHAZ_BAKIM_ISTEK>> GetUnreponsedCallsByPersonelSeq(double personelSeq);
        Task<CIHAZ_BAKIM_ISTEK> Forward(CIHAZ_BAKIM_ISTEK istek);
        Task<CIHAZ_BAKIM_ISTEK> FindByAsync(Expression<Func<CIHAZ_BAKIM_ISTEK, bool>> predicate, bool trace = false);
        Task<CIHAZ_BAKIM_YONLENDIRME> YonlendirmeDetay(CIHAZ_BAKIM_YONLENDIRME yonlendirme);
        Task<CIHAZ_BAKIM> PostCb(CIHAZ_BAKIM cb);
        Task<CIHAZ_BAKIM_ISTEK> Put(CIHAZ_BAKIM_ISTEK istek);
        Task<CIHAZ_BAKIM_SEBEBI> CihazBakimSebebi(int sebepId);
    }
}
