using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Ticket : Person
    {
        
        public Ticket()
        {

        }
       
        public override int Login(string email, string password)
        {
            string query = string.Format("SELECT * FROM TICKET WHERE " +
                "EMAIL = '{0}' AND PASSWORD = '{1}'", email, password);

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
        }

        /*public DataTable ListCustomer()
        {
            try
            {
                string query = "select * from customer";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddCustomer(Customer c)
        {
            try
            {
                string query = string.Format("INSERT INTO customer(name,email,password,tcKimlik,phoneNumber) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')", c.Name, c.Email, c.Password, c.TcKimlik, c.PhoneNumber);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateCustomer(Customer c)
        {
            try
            {
                string query = string.Format("UPDATE customer set name='{0}', email = '{1}',password = '{2}' ,phoneNumber = '{4}' " +
                    " WHERE TcKimlik = {3}", c.Name, c.Email, c.Password, c.TcKimlik, c.PhoneNumber);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteCustomer(Customer c)
        {
            try
            {
                string query = string.Format("DELETE FROM  customer " +
                    " WHERE TcKimlik = {0}", c.TcKimlik);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/

    }
}
