using KeahTekSerAppAPI.Database.Entites;
using Microsoft.EntityFrameworkCore;

namespace KeahTekSerAppAPI.Database
{
    public class DatabaseConnection : Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseConnection(DbContextOptions options) : base(options)
        {
        }

        
        public virtual DbSet<BLOK_TANIM> BLOK_TANIM { get; set; }
        public virtual DbSet<CIHAZ> CIHAZ { get; set; }
        public virtual DbSet<CIHAZ_AKTARIM> CIHAZ_AKTARIM { get; set; }
        public virtual DbSet<CIHAZ_BAKIM> CIHAZ_BAKIM { get; set; }
        public virtual DbSet<CIHAZ_BAKIM_ISTEK> CIHAZ_BAKIM_ISTEK { get; set; }
        public virtual DbSet<CIHAZ_BAKIM_PLAN> CIHAZ_BAKIM_PLAN { get; set; }
        public virtual DbSet<CIHAZ_BAKIM_SEBEBI> CIHAZ_BAKIM_SEBEBI { get; set; }
        public virtual DbSet<CIHAZ_BAKIM_SOZLESME> CIHAZ_BAKIM_SOZLESME { get; set; }
        public virtual DbSet<CIHAZ_BAKIM_YONLENDIRME> CIHAZ_BAKIM_YONLENDIRME { get; set; }
        public virtual DbSet<CIHAZ_BLOB_DATA> CIHAZ_BLOB_DATA { get; set; }
        public virtual DbSet<CIHAZ_CALISMA> CIHAZ_CALISMA { get; set; }
        public virtual DbSet<CIHAZ_KALIBRASYON> CIHAZ_KALIBRASYON { get; set; }
        public virtual DbSet<PERSONEL> PERSONEL { get; set; }
        public virtual DbSet<YETKILI> YETKILI { get; set; }
        public virtual DbSet<PERSONEL_TABLOSU> PERSONEL_TABLOSU { get; set; }
    }
}
