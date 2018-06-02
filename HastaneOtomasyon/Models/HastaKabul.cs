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
    class HastaKabul
    {
        private int _kabulID;
        private int _hastaID;
        private int _doktorID;
        private int _klinikID;
        private int _sikayetID;
        private DateTime _gelisTarih;
        private string _hastaTuru;
        private DateTime _cikisTarih;

        #region Properties
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

        public DateTime GelisTarih
        {
            get
            {
                return _gelisTarih;
            }

            set
            {
                _gelisTarih = value;
            }
        }

        public string HastaTuru
        {
            get
            {
                return _hastaTuru;
            }

            set
            {
                _hastaTuru = value;
            }
        }

        public DateTime CikisTarih
        {
            get
            {
                return _cikisTarih;
            }

            set
            {
                _cikisTarih = value;
            }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void MuayeneListesiniGetir(int PersonelID,ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("Select tcKimlikNo,ad,soyad,kurumAd,cinsiyet,HastaKabul.hastaKabulID,HastaKabul.hastaID,Kurumlar.kurumID from Hastalar inner join Kurumlar on Hastalar.kurumNo=Kurumlar.kurumID inner join HastaKabul on HastaKabul.hastaID=Hastalar.hastaID inner join Personeller on Personeller.personelID=HastaKabul.personelID where personelID=@personelID ",conn);
            comm.Parameters.Add("@personelID",SqlDbType.Int).Value=PersonelID;
            if (conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                if (dr.HasRows)
                {
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
                        i++;

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
