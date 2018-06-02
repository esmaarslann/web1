using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    class Teshisler
    {
        private int _teshisID;
        private int _doktorID;
        private int _kabulID;
        private DateTime _tarih;
        private string _teshis;

        #region Properties
        public int TeshisID
        {
            get
            {
                return _teshisID;
            }

            set
            {
                _teshisID = value;
            }
        }

        public int DoktorID
        {
            get
            {
                return _doktorID;
            }

            set
            {
                _doktorID = value;
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

        public string Teshis
        {
            get
            {
                return _teshis;
            }

            set
            {
                _teshis = value;
            }
        }
        #endregion



        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool TeshisEkle(Teshisler t)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Teshisler(teshis,doktorID,kabulID) values(@teshis,@doktorID,kabulID)", conn);
            comm.Parameters.Add("@doktorID", SqlDbType.Int).Value = t._doktorID;
            comm.Parameters.Add("@teshis", SqlDbType.VarChar).Value = t._teshis;
            comm.Parameters.Add("@kabulID", SqlDbType.Int).Value =t._kabulID;

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
