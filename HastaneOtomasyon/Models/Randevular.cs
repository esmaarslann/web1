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
    class Randevular
    {
        private int _randevuID;
        private int _personelID;
        private int _hastaID;
        private DateTime _tarih;
        private string _saat;
        private int _dakika;

        #region Properties
        public int RandevuID
        {
            get
            {
                return _randevuID;
            }

            set
            {
                _randevuID = value;
            }
        }

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

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
            }
        }

        public string Saat
        {
            get
            {
                return _saat;
            }

            set
            {
                _saat = value;
            }
        }

      

        public int Dakika
        {
            get
            {
                return _dakika;
            }

            set
            {
                _dakika = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool RandevuKaydet(Randevular r)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Randevular(tarih,saat,personelID,hastaID) values(@tarih,@saat,@personelID,@hastaID)", conn);
            comm.Parameters.Add("@hastaID",SqlDbType.Int).Value=r._hastaID;
            comm.Parameters.Add("@personelID", SqlDbType.Int).Value = r._personelID;
            comm.Parameters.Add("@saat", SqlDbType.VarChar).Value = r._saat;
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = r._tarih;


            if (conn.State==ConnectionState.Closed)
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

      



        //public bool RandevuVer(string Tarih,string Saat,int personelID)
        //{
        //    bool Sonuc = false;
        //    SqlCommand comm = new SqlCommand("Select tarih,saat from Randevular where Convert(varchar(20),tarih,104)=@tarih and Convert(varchar(5),getdate(),8)=@saat and personelID=@personelID",conn);
        //    comm.Parameters.Add("@tarih", SqlDbType.VarChar).Value = Tarih ;
        //    comm.Parameters.Add("@saat",SqlDbType.VarChar).Value=Saat;
        //    comm.Parameters.Add("@personelID",SqlDbType.Int).Value=personelID;
        //    if (conn.State==ConnectionState.Closed)
        //    {
        //        conn.Open();
        //    }
        //    SqlDataReader dr;
        //    try
        //    {
        //        dr = comm.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            while(dr.Read())
        //            {


        //                Sonuc = true;


        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {

        //        string hata = ex.Message;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return Sonuc;



        //}

        public bool RandevuTara(int PersonelID, string randevuTarih,string saat)
        {

            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("select * from Randevular where personelID=@personelID and Convert(varchar(20),tarih,104)=@randevuTarih and saat=@saat",conn);
            comm.Parameters.Add("@saat",SqlDbType.VarChar).Value=saat;
            comm.Parameters.Add("@personelID",SqlDbType.Int).Value=PersonelID;
            comm.Parameters.Add("@randevuTarih", SqlDbType.VarChar).Value = randevuTarih;

            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
              
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Sonuc = true;
                        
                      


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

            return Sonuc;
      
            


        }
        public bool RandevuAyniGunMu(Randevular r)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Select * from Randevular where hastaID=@hastaID and personelID=@personelID and tarih=@tarih",conn);
            comm.Parameters.Add("@hastaID",SqlDbType.Int).Value=r._hastaID;
            comm.Parameters.Add("@personelID", SqlDbType.Int).Value = r._personelID;
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = r._tarih;



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
                        Sonuc = true;

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

            return Sonuc;



        }


        internal bool RandevuTaraByRandevuIptalTarih(int hekimID, int seciliHastaID, ComboBox RandevuTarih)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Select tarih from Randevular where personelID=@personelID and hastaID=@hastaID ",conn);
            comm.Parameters.Add("@personelID",SqlDbType.Int).Value=hekimID;
            comm.Parameters.Add("@hastaID",SqlDbType.Int).Value=seciliHastaID;
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

                        RandevuTarih.Items.Add(dr[0].ToString());
                        Sonuc = true;
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
            return Sonuc;

        }
        internal void RandevuTaraByRandevuIptalSaat(int hekimID, int seciliHastaID,string tarih, ComboBox RandevuSaat)
        {
            
            SqlCommand comm = new SqlCommand("Select saat from Randevular where personelID=@personelID and hastaID=@hastaID and tarih=@tarih ", conn);
            comm.Parameters.Add("@personelID", SqlDbType.Int).Value = hekimID;
            comm.Parameters.Add("@hastaID", SqlDbType.Int).Value = seciliHastaID;
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = Convert.ToDateTime(tarih);
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
                    while (dr.Read())
                    {

                        RandevuSaat.Items.Add(dr[0].ToString());
                       
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
          
        }
        internal bool RandevuSil(int hekimID, int seciliHastaID, string tarih, string saat)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Delete from Randevular where personelID=@personelID and hastaID=@hastaID and tarih=@tarih and saat=@saat", conn);
            comm.Parameters.Add("@personelID",SqlDbType.Int).Value=hekimID;
            comm.Parameters.Add("@hastaID", SqlDbType.Int).Value = seciliHastaID;
            comm.Parameters.Add("@tarih", SqlDbType.DateTime).Value = Convert.ToDateTime(tarih);
            comm.Parameters.Add("@saat", SqlDbType.VarChar).Value = saat;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //SqlDataReader dr;
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
