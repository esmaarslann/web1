using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace HastaneOtomasyon.Models
{
    class Klinikler
    {
        private int _klinikNo;
        private string _klinikAd;
        private int _randevuSure;
        private string _aciklama;

        #region Properties
        public int KlinikNo
        {
            get
            {
                return _klinikNo;
            }

            set
            {
                _klinikNo = value;
            }
        }

        public string KlinikAd
        {
            get
            {
                return _klinikAd;
            }

            set
            {
                _klinikAd = value;
            }
        }



        public int RandevuSure
        {
            get
            {
                return _randevuSure;
            }

            set
            {
                _randevuSure = value;
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
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public int SonKlinikNo()
        {
            int SonKlinikNo = 0;
            SqlCommand comm = new SqlCommand("Select * from Klinikler", conn);

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

                    SonKlinikNo = Convert.ToInt32(dr[0]);

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

            return SonKlinikNo + 1;
        }

        public bool KlinikVarmi(string klinikAd)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Select klinikAd from Klinikler where klinikAd=@klinikAd", conn);
            comm.Parameters.Add("@klinikAd", SqlDbType.VarChar).Value = klinikAd;

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

        public bool KlinikEkle(Klinikler k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Klinikler(klinikAd,randevuSure,aciklama) values (@klinikAd,@randevuSure,@aciklama)", conn);
            comm.Parameters.Add("@klinikAd", SqlDbType.VarChar).Value = k._klinikAd;
            comm.Parameters.Add("@randevuSure", SqlDbType.Int).Value = k._randevuSure;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = k._aciklama;

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

        public void KlinikleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Klinikler where silindi=0",conn);
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
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
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

        public bool KlinikDuzenle(Klinikler k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Klinikler set klinikAd =@klinikAd,randevuSure=@randevuSure,aciklama=@aciklama where klinikNo=@klinikNo",conn);
            comm.Parameters.Add("@klinikAd",SqlDbType.VarChar).Value= k._klinikAd;
            comm.Parameters.Add("@klinikNo", SqlDbType.Int).Value = k._klinikNo;
            comm.Parameters.Add("@randevuSure", SqlDbType.Int).Value = k._randevuSure;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = k._aciklama;
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

        public bool KlinikSil(Klinikler k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Klinikler set silindi=1 where klinikNo=@klinikNo ", conn);
           
            comm.Parameters.Add("@klinikNo", SqlDbType.Int).Value = k._klinikNo;
          
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

        public void AdaGoreArama(string AdaGore,ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select klinikNo,klinikAd,randevuSure,aciklama from Klinikler where silindi =0 and klinikAd like @AdaGore + '%' ",conn);
            comm.Parameters.Add("@Adagore",SqlDbType.VarChar).Value=AdaGore;

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
                   
                    i++;
                }
            }
            dr.Close();
            conn.Close();



        }

        public void KlinikAdiGetir(ComboBox liste)
        {

            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Klinikler where silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Klinikler k = new Klinikler();
                    k._klinikNo = Convert.ToInt32(dr["klinikNo"]);
                    k._klinikAd = dr["klinikAd"].ToString();


                    liste.Items.Add(k);
                }
            }
            dr.Close();
            conn.Close();




        }

        public override string ToString()
        {
            return KlinikAd;
        }

        public int KlinikIDBul(string KlinikAdi)
        {
            int Sonuc = -1;
            SqlCommand comm = new SqlCommand("Select klinikNo from Klinikler where klinikAd=@klinikAd",conn);
            comm.Parameters.Add("@klinikAd",SqlDbType.VarChar).Value=KlinikAdi;

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



                        Sonuc = Convert.ToInt32(dr[0]);


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

        public string KlinikAdiGetir(int klinikID)
        {
            string klinikAd="";
            SqlCommand comm = new SqlCommand("select klinikAd from Klinikler where klinikNo=@klinikNo",conn);
            comm.Parameters.Add("@klinikNo",SqlDbType.Int).Value=klinikID;

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
                        klinikAd = dr[0].ToString();
                    }
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
            return klinikAd;




        }

        public void KlinikTurGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Klinikler", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Klinikler kk = new Klinikler();
                    kk._klinikNo = Convert.ToInt32(dr["KlinikNo"]);
                    kk._klinikAd = dr["KlinikAd"].ToString();
                    liste.Items.Add(kk);
                }
            }
            dr.Close();
            conn.Close();
        }



    }
}


