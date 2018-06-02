using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    class HastaSikayetleri
    {
        private int _sikayetID;
        private int _hastaID;
        private int _kabulID;
        private DateTime _tarih;
        private string _aciklama;

        #region Properties
        public int SikayetID
        {
            get
            {
                return _sikayetID;
            }

            set
            {
                _sikayetID = value;
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
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool HastaSikayetleriEkle(HastaSikayetleri hs)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into HastaSikayetleri(aciklama,hastaID,kabulID) values(@aciklama,@hastaID,kabulID)", conn);
            comm.Parameters.Add("@hastaID", SqlDbType.Int).Value = hs._hastaID;
            comm.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = hs._aciklama;
            comm.Parameters.Add("@kabulID", SqlDbType.Int).Value = hs._kabulID;

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
