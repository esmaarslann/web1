using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    class Tahliller
    {
        private int _tahlilID;
        private int _kabulID;
        private DateTime _tarih;
        private string _aciklama;
        private string _sonuc;

        #region Properties
        public int TahlilID
        {
            get
            {
                return _tahlilID;
            }

            set
            {
                _tahlilID = value;
            }
        }

        public int KabulID
        {
            get
            {
                return _kabulID;
            }

            set
            {
                _kabulID = value;
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

        public string Sonuc
        {
            get
            {
                return _sonuc;
            }

            set
            {
                _sonuc = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        public bool TahlilEkle(Tahliller th)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Tahliller(aciklama,kabulID) values(@aciklama,kabulID)", conn);
            
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = th._aciklama;
            comm.Parameters.Add("@kabulID", SqlDbType.Int).Value = th._kabulID;

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
