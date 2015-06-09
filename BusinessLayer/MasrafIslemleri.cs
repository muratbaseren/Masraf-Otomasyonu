using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MasrafIslemleri
    {
        SqlDataProvider provider = new SqlDataProvider(Constants.ConnectionString);

        public int MasrafEkle(Masraf masraf)
        {
            string sorgu = "INSERT INTO Masraf(Id, Baslik, Tarih, Tutar, Aciklama, PersonelId, DurumId) VALUES(@Id, @Baslik, @Tarih, @Tutar, @Aciklama, @PersonelId, @DurumId)";

            provider.Command.Parameters.Clear();

            //provider.Command.Parameters.AddWithValue("@Id", Guid.NewGuid());
            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);
            provider.Command.Parameters.AddWithValue("@Baslik", masraf.Baslik);
            provider.Command.Parameters.AddWithValue("@Tarih", masraf.Tarih.Date);
            provider.Command.Parameters.AddWithValue("@Tutar", masraf.Tutar);
            provider.Command.Parameters.AddWithValue("@Aciklama", masraf.Aciklama);
            provider.Command.Parameters.AddWithValue("@PersonelId", masraf.PersonelId);
            provider.Command.Parameters.AddWithValue("@DurumId", masraf.DurumId);

            return provider.RunQuery(sorgu);
        }

        public List<Masraf> GetirMasraflar(int personelId)
        {
            List<Masraf> masraflar = new List<Masraf>();

            string sorgu = "SELECT Id, Baslik, Tarih, Tutar, Aciklama, PersonelId, DurumId FROM Masraf WHERE PersonelId = @PersonelId";

            provider.Command.Parameters.Clear();
            provider.Command.Parameters.AddWithValue("@PersonelId", personelId);

            DataTable dt = provider.GetDataTable(sorgu); 

            if(dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Masraf masraf = new Masraf()
                    {
                        Id = new Guid(dr["Id"].ToString()),
                        Baslik = dr["Baslik"].ToString(),
                        Aciklama = dr["Aciklama"].ToString(),
                        Tarih = (DateTime)dr["Tarih"],
                        Tutar = (decimal)dr["Tutar"],
                        PersonelId = (int)dr["PersonelId"],
                        DurumId = (byte)dr["DurumId"]
                    };

                    masraflar.Add(masraf);
                }
            }

            return masraflar;
        }

        public int MasrafGuncelle(Masraf masraf)
        {
            string sorgu = "UPDATE Masraf SET Baslik=@Baslik, Tarih=@Tarih, Tutar=@Tutar, Aciklama=@Aciklama, DurumId=@DurumId WHERE Id=@Id";

            provider.Command.Parameters.Clear();

            //provider.Command.Parameters.AddWithValue("@Id", Guid.NewGuid());
            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);
            provider.Command.Parameters.AddWithValue("@Baslik", masraf.Baslik);
            provider.Command.Parameters.AddWithValue("@Tarih", masraf.Tarih.Date);
            provider.Command.Parameters.AddWithValue("@Tutar", masraf.Tutar);
            provider.Command.Parameters.AddWithValue("@Aciklama", masraf.Aciklama);
            provider.Command.Parameters.AddWithValue("@DurumId", masraf.DurumId);

            return provider.RunQuery(sorgu);
        }

        public int MasrafSil(Masraf masraf)
        {
            string sorgu = "DELETE FROM Masraf WHERE Id=@Id";

            provider.Command.Parameters.Clear();

            provider.Command.Parameters.AddWithValue("@Id", masraf.Id);

            return provider.RunQuery(sorgu);
        }
    }
}
