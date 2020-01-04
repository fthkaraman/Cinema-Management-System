using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Movie:Cinema
    {
        int dateTime;
        string place;
        int date;

        public Movie()
        {

        }

        public Movie(int dateTime, string place, int date, string title)
            :base(title)
        {
            this.DateTime = dateTime;
            this.Place = place;
            this.Date = date;
        }

        public int DateTime { get => dateTime; set => dateTime = value; }
        public string Place { get => place; set => place = value; }
        public int Date { get => date; set => date = value; }

        /*public override int Check(string title)
        {
            string query = string.Format("SELECT * FROM CINEMA WHERE " +
                "TITLE = '{0}' AND DATE = '{1}'", title, Date);

            DataAcess da = new DataAcess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }*/

        public DataTable ListMovie()
        {
            try
            {
                string query = "select * from movie";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddMovie(Movie m)
        {
            try
            {
                string query = string.Format("INSERT INTO movie(title,dateTime,place,date) " +
                    "VALUES('{0}','{1}','{2}','{3}')", m.Title, m.DateTime, m.Place, m.Date);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateMovie(Movie m)
        {
            try
            {
                string query = string.Format("UPDATE movie set Title = '{0}',Place = '{2}' ,Date = '{3}' " +
                    " WHERE DateTime = {1}", m.Title, m.DateTime, m.Place, m.Date);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteMovie(Movie m)
        {
            try
            {
                string query = string.Format("DELETE FROM  movie " +
                    " WHERE DateTime = {0}", m.DateTime);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
