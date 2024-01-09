using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ERPCore.Models
{
    public class EmployeeModel
    {
        SqlConnection con = new SqlConnection("server=.;database=student;user=sa;password=1234");
        public string AddEmployeeRecord(Employee employeeEntities)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Employee_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeName", employeeEntities.EmployeeName);
                cmd.Parameters.AddWithValue("@Gender", employeeEntities.Gender);
                cmd.Parameters.AddWithValue("@Address", employeeEntities.Address);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
        public List<Employee> SelectEmployeeRecord()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from employee", con);
                con.Open();

                // Executing the SQL query  
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeName = reader["EmployeeName"].ToString();
                    employee.Address = reader["Address"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employees.Add(employee);
                }
                cmd.ExecuteNonQuery();
                con.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return employees;
        }

    }
}