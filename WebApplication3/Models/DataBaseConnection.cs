using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class DataBaseConnection
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-JHI4R85;Database=Sample1;Integrated Security=True");


        public bool EmpLogin(string emp)
        {
            bool status = false;
            try
            {
                string query = "select * from Employee1 where emp_name='" + emp + "'";

              SqlCommand cmd=new SqlCommand(query, con);
                con.Open();
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    status = true;
                }
                else
                {
                    status = true;
                }

                
             
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return status;
        }




        



    }
}