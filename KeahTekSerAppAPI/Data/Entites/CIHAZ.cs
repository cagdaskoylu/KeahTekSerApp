using System;
using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ
    {
        public DateTime A_F_GARANTI_BAS_TARIH { get; set; }
        public DateTime A_F_GARANTI_BIT_TARIH { get; set; }
        public int ANLASMALI_FIRM_SEQ { get; set; }
        public string BAKIM_ONARIM_KLAVUZU_ACIKLAMA { get; set; }
        public string BAKIM_ONARIM_KLAVUZU_VAR { get; set; }
        public double BAKIM_ONARIM_SOZLESME_BEDEL { get; set; }
        public string BAKIM_ONARIM_SOZLESME_VAR { get; set; }
        public int BAKIM_ONARIM_SURESI_BIRIM { get; set; }
        public bool BAKIM_ONCELIK { get; set; }
        public long BARKOD { get; set; }
        public string CIHAZ_ADI { get; set; }
        public int CIHAZ_ANLASMALI_FIRMA { get; set; }
        public string CIHAZ_ARIZA_MUDAHALE_KISI { get; set; }
        public string CIHAZ_ARIZA_MUDAHALE_ZAMAN { get; set; }
        public int CIHAZ_BAKIM_ANLASMA_FIRMA { get; set; }
        public DateTime CIHAZ_BAKIM_ANLASMA_TARIH_BAS { get; set; }
        public DateTime CIHAZ_BAKIM_ANLASMA_TARIH_BIT { get; set; }
        public string CIHAZ_GARANTI_BILGISI { get; set; }
        public int CIHAZ_ITHALATCI_FIRMA { get; set; }
        public int CIHAZ_KULLANIM_OMRU { get; set; }
        public int CIHAZ_KULLANIM_OMRU_BIRIM { get; set; }
        public string CIHAZ_MARKA { get; set; }
        public string CIHAZ_MODEL { get; set; }
        [Key]
        public int CIHAZ_SEQ { get; set; }
        public string CIHAZ_SERI_NO { get; set; }
        public string CIHAZ_TEKNIK_BILGI { get; set; }
        public int CIHAZ_URETICI_FIRMA { get; set; }
        public DateTime CIHAZ_URETIM_TAR { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public int CREATE_PER_SEQ { get; set; }
        public string CREATE_USER { get; set; }
        public int DEMIRBAS_SEQ { get; set; }
        public string FATURA_NO { get; set; }
        public DateTime FATURA_TARIH { get; set; }
        public string GARANTI_VAR { get; set; }
        public string GEREKLI_BILGILER { get; set; }
        public DateTime I_F_GARANTI_BAS_TAR { get; set; }
        public DateTime I_F_GARANTI_BIT_TAR { get; set; }
        public string IRSALIYE_NO { get; set; }
        public DateTime IRSALIYE_TARIH { get; set; }
        public string KALIBRASYON_BILGI_TNM_GEREKLI { get; set; }
        public int KALIBRASYON_FIRM_SEQ { get; set; }
        public int KALIBRASYON_PERYODU { get; set; }
        public int KALIBRASYON_PERYODU_BIRIM { get; set; }
        public double KALIBRASYON_SOZLESME_BEDEL { get; set; }
        public string KALIBRASYON_SOZLESME_VAR { get; set; }
        public DateTime KALIBRASYON_TARIH_BAS { get; set; }
        public DateTime KALIBRASYON_TARIH_BIT { get; set; }
        public int KULL_HIZMET_BIRIMI { get; set; }
        public string KULLANIM_EL_KITABI_ACIKLAMA { get; set; }
        public string KULLANIM_EL_KITABI_VAR { get; set; }
        public int KULLANIM_SORUMLUSU { get; set; }
        public int MAT_SEQ { get; set; }
        public int PERIYODIK_BAKIM_ONARIM_SURESI { get; set; }
        public string RISK_GRUBU { get; set; }
        public bool RISK_ONCELIK { get; set; }
        public DateTime S_F_GARANTI_BAS_TARIH { get; set; }
        public DateTime S_F_GARANTI_BIT_TARIH { get; set; }
        public int SATICI_FIRMA_SEQ { get; set; }
        public string SOZLESME_ORNEGI_ACIKLAMA { get; set; }
        public string SOZLESME_ORNEGI_VAR { get; set; }
        public int SUBE_SEQ { get; set; }
        public string TALIMAT_ACIKLAMA { get; set; }
        public string TALIMAT_VAR { get; set; }
        public DateTime U_F_GARANTI_BAS_TARIH { get; set; }
        public DateTime U_F_GARANTI_BIT_TARIH { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int UPDATE_PER_SEQ { get; set; }
        public string UPDATE_USER { get; set; }
    }
}
