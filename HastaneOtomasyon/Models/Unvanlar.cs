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
    class Unvanla
    {
        private int _unvanID;
        private string _aciklama;
        private string _personelUnvan;

        #region Properties
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

        public string PersonelUnvan
        {
            get
            {
                return _personelUnvan;
            }

            set
            {
                _personelUnvan = value;
            }
        }
        #endregion


        SqlConnection conn = new SqlConnection(Genel.connStr);
        public int UnvanTurNoGetirByTureGore(string UnvanTuru)
        {
            int TurNo = 0;
            SqlCommand comm = new SqlCommand("Select unvanID from Unvanlar where personelUnvan = @personelUnvan ", conn);
            comm.Parameters.Add("@personelUnvan", SqlDbType.VarChar).Value = UnvanTuru;
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



        public void UnvanTurGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select * from Unvanlar", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Unvanla u = new Unvanla();
                    u._unvanID = Convert.ToInt32(dr["UnvanID"]);
                    u._personelUnvan = dr["PersonelUnvan"].ToString();
                    liste.Items.Add(u);
                }
            }
            dr.Close();
            conn.Close();
        }
        public override string ToString()
        {
            return PersonelUnvan;
        }



    }
}
