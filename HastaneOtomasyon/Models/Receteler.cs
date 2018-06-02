using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Models
{
    class Receteler
    {
        private int _receteNo;
        private int _kabulID;
        private int _kurumID;
        private int _personelID;
        private int _hastaID;
        private DateTime _tarih;
        private string _ilacAd;
        private string _ilacDoz;

        #region Properties
        public int ReceteNo
        {
            get
            {
                return _receteNo;
            }

            set
            {
                _receteNo = value;
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

        public string IlacAd
        {
            get
            {
                return _ilacAd;
            }

            set
            {
                _ilacAd = value;
            }
        }

        public string IlacDoz
        {
            get
            {
                return _ilacDoz;
            }

            set
            {
                _ilacDoz = value;
            }
        }
        #endregion


        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool ReceteEkle(Receteler r)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Insert into Receteler(kabulID,kurumID,personelID,hastaID,ilacAd) values(@kabulID,@kurumId,@personelID,@hastaID,@ilacAd)", conn);

          
            comm.Parameters.Add("@kabulID", SqlDbType.Int).Value = r._kabulID;
            comm.Parameters.Add("@kurumId", SqlDbType.Int).Value = r._kurumID;
            comm.Parameters.Add("@personelID", SqlDbType.Int).Value = r._personelID;
            comm.Parameters.Add("@hastaID", SqlDbType.Int).Value = r._hastaID;
            comm.Parameters.Add("@ilacAd", SqlDbType.VarChar).Value = r._ilacAd;

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
