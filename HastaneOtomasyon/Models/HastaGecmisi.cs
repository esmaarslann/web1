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
    class HastaGecmisi
    {
        private int _gecmisID;
        private int _hastaID;
        private DateTime _tarih;
        private string _aciklama;

        #region Properties
        public int GecmisID
        {
            get
            {
                return _gecmisID;
            }

            set
            {
                _gecmisID = value;
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

        public bool HastaGecmisiEkle(HastaGecmisi hg)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into HastaGecmisi(aciklama,hastaID) values(@aciklama,@hastaID)",conn);
            comm.Parameters.Add("@hastaID",SqlDbType.Int).Value=hg._hastaID;
            comm.Parameters.Add("@aciklama",SqlDbType.VarChar).Value=hg._aciklama;

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

        public bool HastaGecmisiDuzenle(HastaGecmisi hg)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update HastaGecmisi set aciklama=@aciklama where gecmisID=@gecmisID",conn);

            comm.Parameters.Add("@gecmisID", SqlDbType.Int).Value = hg._gecmisID;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = hg._aciklama;


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

        public bool HastaGecmisiSil(int gecmisID)
        {

            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update HastaGecmisi set silindi=1 where gecmisID=@gecmisID", conn);

            comm.Parameters.Add("@gecmisID", SqlDbType.Int).Value = gecmisID;
         

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

        public void HastaGecmisiGetir(ListView liste)
        {

            SqlCommand comm = new SqlCommand("Select tarih,aciklama,hastaID,gecmisID from HastaGecmisi where silindi=0",conn);

            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            int i = 0;
            SqlDataReader dr; 
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());





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



    }
}
