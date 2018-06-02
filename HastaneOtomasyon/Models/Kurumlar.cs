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
    class Kurumlar
    {
        private int _kurumID;
        private string _kurumAd;
        private int _iskonto;

        #region Properties
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

        public string KurumAd
        {
            get
            {
                return _kurumAd;
            }

            set
            {
                _kurumAd = value;
            }
        }

        public int Iskonto
        {
            get
            {
                return _iskonto;
            }

            set
            {
                _iskonto = value;
            }
        }
        #endregion
        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void KurumlariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Kurumlar where silindi=0", conn);
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
            SqlCommand comm = new SqlCommand("Select kurumID,kurumAd,iskonto from Kurumlar where silindi =0 and kurumAd like @AdaGore + '%' ", conn);
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
                    

                    i++;
                }
            }
            dr.Close();
            conn.Close();



        }


        public bool KurumEkle(Kurumlar k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Kurumlar(kurumAd,iskonto) values (@kurumAd,@iskonto)", conn);
            comm.Parameters.Add("@kurumAd", SqlDbType.VarChar).Value = k._kurumAd;
            comm.Parameters.Add("@iskonto", SqlDbType.Int).Value = k._iskonto;
           

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

        public bool KurumSil(Kurumlar k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Kurumlar set silindi=1 where kurumID=@kurumID ", conn);

            comm.Parameters.Add("@kurumID", SqlDbType.Int).Value = k._kurumID;

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


        public bool KurumDuzenle(Kurumlar k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Kurumlar set kurumAd =@kurumAd,iskonto=@iskonto where kurumID=@kurumID", conn);
            comm.Parameters.Add("@kurumAd", SqlDbType.VarChar).Value = k._kurumAd;
            comm.Parameters.Add("@kurumID", SqlDbType.Int).Value = k._kurumID;
            comm.Parameters.Add("@iskonto", SqlDbType.Int).Value = k._iskonto;
 
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

        public bool KurumVarmi(string kurumAd)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Select kurumAd from Kurumlar where kurumAd=@kurumAd", conn);
            comm.Parameters.Add("@kurumAd", SqlDbType.VarChar).Value = kurumAd;

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

        public int SonKurumNo()
        {
            int SonKurumNo = 0;
            SqlCommand comm = new SqlCommand("Select * from Kurumlar", conn);

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

                    SonKurumNo = Convert.ToInt32(dr[0]);

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

            return SonKurumNo + 1;
        }

        public int KurumTurNoGetirByTureGore(string KurumTuru)
        {
            int TurNo = 0;
            SqlCommand comm = new SqlCommand("Select kurumID from Kurumlar where kurumAd = @KurumAd and Silindi=0", conn);
            comm.Parameters.Add("@kurumAd", SqlDbType.VarChar).Value = KurumTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                TurNo = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                
            }
           
            conn.Close();
            return TurNo;
        }



        public void KurumTurleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Kurumlar", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Kurumlar k = new Kurumlar();
                    k._kurumID = Convert.ToInt32(dr["KurumID"]);
                    k._kurumAd = dr["KurumAd"].ToString();
                    liste.Items.Add(k);
                }
            }
            dr.Close();
            conn.Close();
        }
        public override string ToString()
        {
            return KurumAd;
        }
























    }
}
