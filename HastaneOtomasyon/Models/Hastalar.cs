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
    class Hastalar
    {
        private int _hastaID;
     
        private string _ad;
        private string _soyad;
        private string _tcKimlikNo;
        private string _adres;
        private string _il;
        private string _ilce;
        private string _evTel;
        private string _cepTel;
        private string _kanGrubu;
        private string _babaAd;
        private string _anneAd;
        private string _dogumYeri;
        private DateTime _dogumTarihi;
        private string _cinsiyet;
        private string _medeniHali;
        private string _oncekiSoyad;
        private string _vergiNo;
        private int _kurumID;
        private DateTime _kayitTarihi;

        #region Properties
        public int HastaID
        {
            get
            {
                return _hastaID;
            }

            set
            {
                _hastaID = value;
            }
        }

  

        public string Ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }

        public string TcKimlikNo
        {
            get
            {
                return _tcKimlikNo;
            }

            set
            {
                _tcKimlikNo = value;
            }
        }

        public string Adres
        {
            get
            {
                return _adres;
            }

            set
            {
                _adres = value;
            }
        }

        public string Il
        {
            get
            {
                return _il;
            }

            set
            {
                _il = value;
            }
        }

        public string Ilce
        {
            get
            {
                return _ilce;
            }

            set
            {
                _ilce = value;
            }
        }

        public string EvTel
        {
            get
            {
                return _evTel;
            }

            set
            {
                _evTel = value;
            }
        }

        public string CepTel
        {
            get
            {
                return _cepTel;
            }

            set
            {
                _cepTel = value;
            }
        }

        public string KanGrubu
        {
            get
            {
                return _kanGrubu;
            }

            set
            {
                _kanGrubu = value;
            }
        }

        public string BabaAd
        {
            get
            {
                return _babaAd;
            }

            set
            {
                _babaAd = value;
            }
        }

        public string AnneAd
        {
            get
            {
                return _anneAd;
            }

            set
            {
                _anneAd = value;
            }
        }

        public string DogumYeri
        {
            get
            {
                return _dogumYeri;
            }

            set
            {
                _dogumYeri = value;
            }
        }

        public DateTime DogumTarihi
        {
            get
            {
                return _dogumTarihi;
            }

            set
            {
                _dogumTarihi = value;
            }
        }

        public string Cinsiyet
        {
            get
            {
                return _cinsiyet;
            }

            set
            {
                _cinsiyet = value;
            }
        }

        public string MedeniHali
        {
            get
            {
                return _medeniHali;
            }

            set
            {
                _medeniHali = value;
            }
        }

        public string OncekiSoyad
        {
            get
            {
                return _oncekiSoyad;
            }

            set
            {
                _oncekiSoyad = value;
            }
        }

        public string VergiNo
        {
            get
            {
                return _vergiNo;
            }

            set
            {
                _vergiNo = value;
            }
        }

        public int KurumID
        {
            get
            {
                return _kurumID;
            }

            set
            {
                _kurumID = value;
            }
        }

        public DateTime KayitTarihi
        {
            get
            {
                return _kayitTarihi;
            }

            set
            {
                _kayitTarihi = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool KisiKontrol(string TcKimlikNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from Hastalar where tcKimlikNo = @tcKimlikNo and silindi=0", conn);
            comm.Parameters.Add("@tcKimlikNo", SqlDbType.VarChar).Value = TcKimlikNo;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                    Varmi = true;
                dr.Close();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Varmi;
        }
        public bool KisiEkle(Hastalar h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Hastalar(ad,soyad,tcKimlikNo,adres,ilce,il,evTel,cepTel,kanGrubu,babaAd,anneAd,dogumYeri,dogumTarihi,cinsiyet,medeniHali,oncekiSoyad,vergiNo,kayitTarihi,kurumID) values(@ad,@soyad,@tcKimlikNo,@adres,@ilce,@il,@evTel,@cepTel,@kanGrubu,@babaAd,@anneAd,@dogumYeri,@dogumTarihi,@cinsiyet,@medeniHali,@oncekiSoyad,@vergiNo,@kayitTarihi,@kurumID)", conn);
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = h._ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = h._soyad;
            comm.Parameters.Add("@tcKimlikNo", SqlDbType.VarChar).Value = h._tcKimlikNo;
            comm.Parameters.Add("@adres", SqlDbType.VarChar).Value = h._adres;
            comm.Parameters.Add("@ilce", SqlDbType.VarChar).Value = h._ilce;
            comm.Parameters.Add("@il", SqlDbType.VarChar).Value = h._il;
            comm.Parameters.Add("@evTel", SqlDbType.VarChar).Value = h._evTel;
            comm.Parameters.Add("@cepTel", SqlDbType.VarChar).Value = h._cepTel;
            comm.Parameters.Add("@kanGrubu", SqlDbType.VarChar).Value = h._kanGrubu;
            comm.Parameters.Add("@babaAd", SqlDbType.VarChar).Value = h._babaAd;
            comm.Parameters.Add("@anneAd", SqlDbType.VarChar).Value = h._anneAd;
            comm.Parameters.Add("@dogumYeri", SqlDbType.VarChar).Value = h._dogumYeri;
            comm.Parameters.Add("@dogumTarihi", SqlDbType.DateTime).Value = h._dogumTarihi;
            comm.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = h._cinsiyet;
            comm.Parameters.Add("@medeniHali", SqlDbType.VarChar).Value = h._medeniHali;
            comm.Parameters.Add("@oncekiSoyad", SqlDbType.VarChar).Value = h._oncekiSoyad;
            comm.Parameters.Add("@vergiNo", SqlDbType.VarChar).Value = h._vergiNo;
            comm.Parameters.Add("@kayitTarihi", SqlDbType.DateTime).Value = h._kayitTarihi;
            comm.Parameters.Add("@kurumID",SqlDbType.Int).Value=h._kurumID;


            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
            return Sonuc;
        }
        public void HastaGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select ad,soyad,tcKimlikNo,adres,dogumTarihi,evTel,cepTel,kanGrubu,cinsiyet,hastaID From Hastalar where silindi=0", conn);

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
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    liste.Items[i].SubItems.Add(dr[8].ToString());
                    liste.Items[i].SubItems.Add(dr[9].ToString());


                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }


        public void HastalariGetirBySorgulama(string AdaGore, string SoyadaGore, string TcyeGore, ListView liste)
        {

            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select ad,soyad,tcKimlikNo,adres,dogumTarihi,evTel,cepTel,kanGrubu,cinsiyet from Hastalar where ad like @AdaGore + '%' and soyad like @SoyadaGore + '%' and tcKimlikNo like @TcyeGore + '%' and silindi=0", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@SoyadaGore", SqlDbType.VarChar).Value = SoyadaGore;
            comm.Parameters.Add("@TcyeGore", SqlDbType.VarChar).Value = TcyeGore;

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
                    liste.Items[i].SubItems.Add(dr[6].ToString());
                    liste.Items[i].SubItems.Add(dr[7].ToString());
                    liste.Items[i].SubItems.Add(dr[8].ToString());

                    i++;
                }
            }
            dr.Close();
            conn.Close();
        }
        public bool HastaSil(Hastalar h)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Hastalar set  silindi=1  where hastaID=@hastaID", conn);

            comm.Parameters.Add("@hastaID", SqlDbType.Int).Value = h._hastaID;

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
    }
}
