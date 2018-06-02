using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Models
{
    class Hizmetler
    {
        private int _hizmetID;
        private int _klinikID;
        private string _aciklama;
        private double _ucret;
        private string _hizmetAdi;

        #region Properties
        public int HizmetID
        {
            get
            {
                return _hizmetID;
            }

            set
            {
                _hizmetID = value;
            }
        }

        public int KlinikID
        {
            get
            {
                return _klinikID;
            }

            set
            {
                _klinikID = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        }

        public double Ucret
        {
            get
            {
                return _ucret;
            }

            set
            {
                _ucret = value;
            }
        }

        public string HizmetAdi
        {
            get
            {
                return _hizmetAdi;
            }

            set
            {
                _hizmetAdi = value;
            }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void HizmetleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select hizmetID, hizmetAdi, Hizmetler.aciklama, klinikAd, ucret, Klinikler.klinikNo from Hizmetler inner join Klinikler on Hizmetler.klinikID = Klinikler.klinikNo where Hizmetler.silindi = 0", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        i++;



                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {

                conn.Close();

            }





        }
        public void AdaGoreArama(string AdaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select hizmetID, hizmetAdi, Hizmetler.aciklama, klinikAd, ucret, Klinikler.klinikNo from Hizmetler inner join Klinikler on Hizmetler.klinikID = Klinikler.klinikNo where Hizmetler.silindi = 0 and hizmetAdi like @AdaGore +'%'", conn);
            comm.Parameters.Add("@Adagore", SqlDbType.VarChar).Value = AdaGore;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());

                    i++;
                }
            }
            dr.Close();
            conn.Close();



        }
        public void KlinikAdinaGoreArama(string KlinikAdinaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select hizmetID, hizmetAdi, Hizmetler.aciklama, klinikAd, ucret, Klinikler.klinikNo from Hizmetler inner join Klinikler on Hizmetler.klinikID = Klinikler.klinikNo where Hizmetler.silindi = 0 and klinikAd like @KlinikAdinaGore +'%'", conn);
            comm.Parameters.Add("@KlinikAdinaGore", SqlDbType.VarChar).Value = KlinikAdinaGore;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr[0].ToString());
                    liste.Items[i].SubItems.Add(dr[1].ToString());
                    liste.Items[i].SubItems.Add(dr[2].ToString());
                    liste.Items[i].SubItems.Add(dr[3].ToString());
                    liste.Items[i].SubItems.Add(dr[4].ToString());
                    liste.Items[i].SubItems.Add(dr[5].ToString());

                    i++;
                }
            }
            dr.Close();
            conn.Close();



        }
        public bool HizmetSil(Hizmetler h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Hizmetler set silindi=1 where hizmetID=@hizmetID ", conn);

            comm.Parameters.Add("@hizmetID", SqlDbType.Int).Value = h._hizmetID;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {

                conn.Close();

            }


            return Sonuc;

        }
        public bool HizmetDuzenle(Hizmetler h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Hizmetler set hizmetAdi=@hizmetAdi,aciklama=@aciklama,klinikID=@klinikID,ucret=@ucret where hizmetID=@hizmetID",conn);
            comm.Parameters.Add("@hizmetAdi", SqlDbType.VarChar).Value = h._hizmetAdi;
            comm.Parameters.Add("@klinikID", SqlDbType.Int).Value = h._klinikID;
            comm.Parameters.Add("@ucret", SqlDbType.Int).Value = h._ucret;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = h._aciklama;
            comm.Parameters.Add("@hizmetID",SqlDbType.Int).Value=h._hizmetID;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {

                conn.Close();

            }


            return Sonuc;





        }

        public bool HizmetEkle(Hizmetler h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Hizmetler(hizmetAdi,klinikID,aciklama,ucret) values (@hizmetAdi,@klinikID,@aciklama,@ucret)", conn);
            comm.Parameters.Add("@hizmetAdi", SqlDbType.VarChar).Value = h._hizmetAdi;
            comm.Parameters.Add("@klinikID", SqlDbType.Int).Value = h._klinikID;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = h._aciklama;
            comm.Parameters.Add("@ucret", SqlDbType.Int).Value = h._ucret;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {

                conn.Close();

            }


            return Sonuc;
        }

        public bool HizmetVarmi(string hizmetAdi)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Select hizmetAdi from Hizmetler where hizmetAdi=@hizmetlerAdi", conn);
            comm.Parameters.Add("@hizmetAdi", SqlDbType.VarChar).Value = hizmetAdi;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            try
            {

                dr = comm.ExecuteReader();
                if (dr.HasRows)
                    Sonuc = true;
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();

            }

            return Sonuc;
        }

        public int SonHizmetNo()
        {
            int SonHizmetNo = 0;
            SqlCommand comm = new SqlCommand("Select * from Hizmetler", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                while (dr.Read())
                {

                    SonHizmetNo = Convert.ToInt32(dr[0]);

                }

            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }

            finally
            {
                conn.Close();

            }

            return SonHizmetNo + 1;
        }




    }
}
