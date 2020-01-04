using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
  public  class Student:Person
    {
        int studentId;

        public Student()
        {

        }
        public Student(int studentId,string name, string email, string password)
            :base(name,email,password)
        {
            this.studentId = studentId;
        }

        public int StudentId { get => studentId; set => studentId = value; }

        public override int Login(string email, string password)
        {
            string query = string.Format("SELECT * FROM STUDENT WHERE " +
                "EMAIL = '{0}' AND PASSWORD = '{1}'", email, password);

            DataAcess da = new DataAcess();
            DataTable dt =   da.ExecuteQuery(query);

            if (dt.Rows.Count>0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public DataTable ListStudent()
        {
            try
            {
                string query = "select * from student";
                DataAcess da = new DataAcess();
               return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddStudent(Student s)
        {
            try
            {
                string query = string.Format("INSERT INTO student(name,email,password) " +
                    "VALUES('{0}','{1}','{2}')",s.Name,s.Email,s.Password);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateStudent(Student s)
        {
            try
            {
                string query = string.Format("UPDATE student set name='{0}', email = '{1}',password = '{2}' " +
                    " WHERE StudentID = {3}", s.Name, s.Email, s.Password,s.StudentId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteStudent(int id)
        {
            try
            {
                string query = string.Format("DELETE FROM  student " +
                    " WHERE StudentID = {0}", id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

















        /*
        public DataTable ListStudent()
        {
            try
            {
                string query = "select * from student";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception("ListStudent" + ex.Message);
            }
        }

        public int AddStudent(Student s)
        {
            try
            {
                string query = string.Format("insert into student(Name,email,password)" +
                    "values('{0}','{1}','{2}')",s.Name,s.Email,s.Password);
                DataAcess da = new DataAcess();
              return  da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateStudent(Student s)
        {
            try
            {
                string query = string.Format("update student " +
                    "set Name = '{0}', email='{1}', password= '{2}' " +
                    " Where studentID = {3}",s.Name,s.Email,s.Password,s.StudentId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int DeleteStudent(int Id)
        {
            try
            {
                string query = string.Format("delete from student " +
                    " Where studentID = {0}", Id);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception( ex.Message);
            }
        }*/
    }
}
