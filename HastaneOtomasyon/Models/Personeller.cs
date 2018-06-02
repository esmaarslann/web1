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
    class Personeller
    {
        private int _personelID;
        private int _unvanID;
        private int _klinikID;
        private int _sicilNo;
        private string _personelTuru;
        private string _ad;
        private string _soyad;
        private int _diplomaNo;
        private string _adres;
        private string _il;
        private string _ilce;
        private string _evTel;
        private string _cepTel;
        private string _email;
        private DateTime _dogumTarihi;
        private string _dogumYeri;
        private string _kullaniciAdi;
        private string _sifre;

        #region Properties
        public int PersonelID
        {
            get
            {
                return _personelID;
            }

            set
            {
                _personelID = value;
            }
        }

        public int UnvanID
        {
            get
            {
                return _unvanID;
            }

            set
            {
                _unvanID = value;
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

        public int SicilNo
        {
            get
            {
                return _sicilNo;
            }

            set
            {
                _sicilNo = value;
            }
        }

        public string PersonelTuru
        {
            get
            {
                return _personelTuru;
            }

            set
            {
                _personelTuru = value;
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

        public int DiplomaNo
        {
            get
            {
                return _diplomaNo;
            }

            set
            {
                _diplomaNo = value;
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

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
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

        public string KullaniciAdi
        {
            get
            {
                return _kullaniciAdi;
            }

            set
            {
                _kullaniciAdi = value;
            }
        }

        public string Sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool KullaniciVarmi(string KullaniciAdi,string Sifre)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select * from Personeller where kullaniciAdi=@kullaniciAdi and sifre=@sifre",conn);
            comm.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = KullaniciAdi ;
            comm.Parameters.Add("@sifre",SqlDbType.VarChar).Value=Sifre;

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Sonuc = true;
                    }
                }
                dr.Close();
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

        public Personeller PersonelBilgileriGetir(string KullaniciAdi,string Sifre)
        {
            Personeller p = new Personeller();
            SqlCommand comm = new SqlCommand("select * from Personeller where kullaniciAdi=@kullaniciAdi and sifre=@sifre",conn);
            comm.Parameters.Add("@kullaniciAdi",SqlDbType.VarChar).Value=KullaniciAdi;
            comm.Parameters.Add("@sifre", SqlDbType.VarChar).Value = Sifre;


            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                      
                        p._personelID = Convert.ToInt32(dr[0]);
                        p._sicilNo = Convert.ToInt32(dr[1]);
                        p._unvanID = Convert.ToInt32(dr[2]);
                        p._klinikID = Convert.ToInt32(dr[3]);
                        p._ad = dr[4].ToString();
                        p._soyad = dr[5].ToString();
                        p._diplomaNo = Convert.ToInt32(dr[6]);
                        p._adres = dr[7].ToString();
                        p._evTel = dr[8].ToString();
                        p._cepTel = dr[9].ToString();
                        p._dogumTarihi = Convert.ToDateTime(dr[10]);
                        p._dogumYeri = dr[11].ToString();
                        



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

            return p;



        }



        public void PersonelAdiGetir(ComboBox liste,string KlinikAd)
        {

            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select ad,soyad from Personeller inner join Klinikler on Personeller.klinikID=Klinikler.klinikNo where Personeller.silindi=0 and unvanID=1 and Klinikler.klinikAd=@klinikAd ", conn);
            comm.Parameters.Add("@klinikAd",SqlDbType.VarChar).Value=KlinikAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Personeller p = new Personeller();
                    p._ad = dr["ad"].ToString();
                    p._soyad = dr["soyad"].ToString();

                    string HekimAd = p._ad + " " + p._soyad;



                    liste.Items.Add(HekimAd);
                }
            }
            dr.Close();
            conn.Close();




        }

        public int HekimIDBul(string HekimAd,string HekimSoyad)
        {
            int ID=0;
            SqlCommand comm = new SqlCommand("Select personelID from Personeller where ad=@HekimAd and soyad=@HekimSoyad ",conn);
            comm.Parameters.Add("@HekimAd",SqlDbType.VarChar).Value=HekimAd;
            comm.Parameters.Add("@HekimSoyad", SqlDbType.VarChar).Value = HekimSoyad;

            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        ID = Convert.ToInt32(dr[0]);

                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return ID;


        }

        public override string ToString()
        {
            return Ad;
        }

        public bool PersonelKontrol(string PersonelAd, string PersonelSoyad, int personelNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("Select * from Personeller where  ad=@ad and soyad=@soyad and personelID != @personelID", conn);
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = PersonelAd;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = PersonelSoyad;
            comm.Parameters.Add("@personelID", SqlDbType.Int).Value = personelNo;

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


        public bool PersonelGuncelle(Personeller p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Personeller set sicilNo=@sicilNo,unvanID=@unvanID,klinikID=@klinikID,ad=@ad,soyad=@soyad,diplomaNo=@diplomaNo,adres=@adres,evTel=@evTel,cepTel=@cepTel,dogumYeri=@dogumYeri,dogumTarihi=@dogumTarihi,kullaniciAdi=@kullaniciAdi,sifre=@sifre where personelID=@personelID", conn);
            comm.Parameters.Add("@sicilNo", SqlDbType.Int).Value = p._sicilNo;
            comm.Parameters.Add("@unvanID", SqlDbType.Int).Value = p._unvanID;
            comm.Parameters.Add("@klinikID", SqlDbType.Int).Value = p._klinikID;
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = p._ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = p._soyad;
            comm.Parameters.Add("@diplomaNo", SqlDbType.Int).Value = p._diplomaNo;
            comm.Parameters.Add("@adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@evTel", SqlDbType.VarChar).Value = p._evTel;
            comm.Parameters.Add("@cepTel", SqlDbType.VarChar).Value = p._cepTel;

            comm.Parameters.Add("@dogumYeri", SqlDbType.VarChar).Value = p._dogumYeri;
            comm.Parameters.Add("@dogumTarihi", SqlDbType.DateTime).Value = p._dogumTarihi;
            comm.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = p._kullaniciAdi;
            comm.Parameters.Add("@sifre", SqlDbType.VarChar).Value = p._sifre;
            comm.Parameters.Add("@personelID", SqlDbType.Int).Value = p._personelID;



            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery()); //Hata verip vermediği kontrol edilir.
            }
            catch (SqlException ex)  //Hatayla karşılaşılması durumunda bu blok çalışır.
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }  //Hata olsun yada olmasın mutlaka çalışır.  
            return Sonuc;
        }


        public void PersonelGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select sicilNo,ad,soyad,personelUnvan,klinikAd,diplomaNo,adres,evTel,cepTel,dogumYeri,dogumTarihi,kullaniciAdi,sifre,personelID from Personeller p inner join Unvanlar u on p.unvanID=u.unvanID inner join Klinikler k on k.klinikNo=p.klinikID", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
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
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
                        liste.Items[i].SubItems.Add(dr[13].ToString());



                        i++;
                    }
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }


        }
        public void PersonelGetirBySorgulama(string AdaGore, string SoyadaGore, ListView liste)
        {

            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select sicilNo,ad,soyad,personelUnvan,klinikAd,diplomaNo,adres,evTel,cepTel,dogumYeri,dogumTarihi,kullaniciAdi,sifre,personelID from Personeller p inner join Unvanlar u on p.unvanID=u.unvanID inner join Klinikler k on k.klinikNo=p.klinikID where ad like @AdaGore + '%' and soyad like @SoyadaGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@SoyadaGore", SqlDbType.VarChar).Value = SoyadaGore;



            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
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
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
                        liste.Items[i].SubItems.Add(dr[13].ToString());

                        i++;
                    }
                }
                dr.Close();
                conn.Close();
            }

            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
        }

        public bool KisiEkle(Personeller p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Personeller(sicilNo,unvanID,klinikID,ad,soyad,diplomaNo,adres,evTel,cepTel,dogumYeri,dogumTarihi,kullaniciAdi,sifre) values(@sicilNo,@unvanID,@klinikID,@ad,@soyad,@diplomaNo,@adres,@evTel,@cepTel,@dogumYeri,@dogumTarihi,@kullaniciAdi,@sifre)", conn);
            comm.Parameters.Add("@sicilNo", SqlDbType.Int).Value = p._sicilNo;
            comm.Parameters.Add("@unvanID", SqlDbType.Int).Value = p._unvanID;
            comm.Parameters.Add("@klinikID", SqlDbType.Int).Value = p._klinikID;
            comm.Parameters.Add("@ad", SqlDbType.VarChar).Value = p._ad;
            comm.Parameters.Add("@soyad", SqlDbType.VarChar).Value = p._soyad;
            comm.Parameters.Add("@diplomaNo", SqlDbType.Int).Value = p._diplomaNo;
            comm.Parameters.Add("@adres", SqlDbType.VarChar).Value = p._adres;
            comm.Parameters.Add("@evTel", SqlDbType.VarChar).Value = p._evTel;
            comm.Parameters.Add("@cepTel", SqlDbType.VarChar).Value = p._cepTel;

            comm.Parameters.Add("@dogumYeri", SqlDbType.VarChar).Value = p._dogumYeri;
            comm.Parameters.Add("@dogumTarihi", SqlDbType.DateTime).Value = p._dogumTarihi;
            comm.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = p._kullaniciAdi;
            comm.Parameters.Add("@sifre", SqlDbType.VarChar).Value = p._sifre;



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




        public bool PersonelSil(Personeller p)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Personeller set  silindi=1  where personelID=@personelID", conn);

            comm.Parameters.Add("@personelID", SqlDbType.Int).Value = p._personelID;

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
