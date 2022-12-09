using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SP_DBCOnnection
{
    public class DBConnection
    {
        public void storedprocedure()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            SqlConnection Conn = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            SqlCommand Cmd = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            try
            {
                Conn = new SqlConnection("Data Source=PPAWAR-LAP-0704\\MSSQLSERVER02;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
                Conn.Open();

                Cmd = Conn.CreateCommand();
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.CommandText = "EmployeeInsert";

                // Now using the Parameters
                SqlParameter pDeptNo = new SqlParameter();
                pDeptNo.ParameterName = "@DeptNo";
                pDeptNo.DbType = System.Data.DbType.Int32;
                pDeptNo.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
                pDeptNo.Value = 10;
                Cmd.Parameters.Add(pDeptNo);


                SqlParameter pDesignation = new SqlParameter();
                pDesignation.ParameterName = "@Designation";
                pDesignation.DbType = System.Data.DbType.String;
                pDesignation.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
                pDesignation.Size = 100;
                pDesignation.Value = "Ma";
                Cmd.Parameters.Add(pDesignation);

                SqlParameter pEmpName = new SqlParameter();
                pEmpName.ParameterName = "@EmpName";
                pEmpName.DbType = System.Data.DbType.String;
                pEmpName.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
                pEmpName.Size = 100;
                pEmpName.Value = "Manish";
                Cmd.Parameters.Add(pEmpName);


                SqlParameter pSalary = new SqlParameter();
                pSalary.ParameterName = "@Salary";
                pSalary.DbType = System.Data.DbType.Int32;
                pSalary.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
                pSalary.Value = 90000;
                Cmd.Parameters.Add(pSalary);

                SqlParameter pEmpNo = new SqlParameter();
                pEmpNo.ParameterName = "@EmpNo";
                pEmpNo.DbType = System.Data.DbType.Int32;
                pEmpNo.Direction = System.Data.ParameterDirection.Input; // DEfault is Input
                pEmpNo.Value = 4;
                Cmd.Parameters.Add(pEmpNo);

                var rdr = Cmd.ExecuteNonQuery();

                Conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error :: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            finally
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                Conn.Dispose();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }
        public void StoredProcedureTran()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            SqlConnection Conn = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            SqlCommand Cmd = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            try
            {
                Conn = new SqlConnection("Data Source=PPAWAR-LAP-0704\\MSSQLSERVER02;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
                Conn.Open();

                Cmd = Conn.CreateCommand();
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.CommandText = "sp_MultiTableInsert ";

                // Now using the Parameters
                // @DeptNo = 203, @DeptName = 'Dept_203', @Location = 'Mumbai',@Capacity = 2000, @EmpNo = 707,@EmpName = 'Mahesh', @Designation = 'Manager',@Salary = 40000;

                SqlParameter pDeptNo = new SqlParameter();
                pDeptNo.ParameterName = "@DeptNo";
                pDeptNo.DbType = System.Data.DbType.Int32;
                pDeptNo.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pDeptNo.Value = 90;
                Cmd.Parameters.Add(pDeptNo);

                SqlParameter pDeptName = new SqlParameter();
                pDeptName.ParameterName = "@DeptName";
                pDeptName.DbType = System.Data.DbType.String;
                pDeptName.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pDeptName.Size = 100;
                pDeptName.Value = "ADMIN";
                Cmd.Parameters.Add(pDeptName);

                SqlParameter pLocation = new SqlParameter();
                pLocation.ParameterName = "@Location";
                pLocation.DbType = System.Data.DbType.String;
                pLocation.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pLocation.Size = 100;
                pLocation.Value = "Pune";
                Cmd.Parameters.Add(pLocation);

                SqlParameter pCapaity = new SqlParameter();
                pCapaity.ParameterName = "@Capacity";
                pCapaity.DbType = System.Data.DbType.Int32;
                pCapaity.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pCapaity.Value = 200;
                Cmd.Parameters.Add(pCapaity);

                SqlParameter pEmpNo = new SqlParameter();
                pEmpNo.ParameterName = "@EmpNo";
                pEmpNo.DbType = System.Data.DbType.Int32;
                pEmpNo.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pEmpNo.Value = 90;
                Cmd.Parameters.Add(pEmpNo);

                SqlParameter pEmpName = new SqlParameter();
                pEmpName.ParameterName = "@EmpName";
                pEmpName.DbType = System.Data.DbType.String;
                pEmpName.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pEmpName.Size = 100;
                pEmpName.Value = "Manny";
                Cmd.Parameters.Add(pEmpName);

                SqlParameter pDesignation = new SqlParameter();
                pDesignation.ParameterName = "@Designation";
                pDesignation.DbType = System.Data.DbType.String;
                pDesignation.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pDesignation.Size = 100;
                pDesignation.Value = "Lead";
                Cmd.Parameters.Add(pDesignation);
             
                SqlParameter pSalary = new SqlParameter();
                pSalary.ParameterName = "@Salary";
                pSalary.DbType = System.Data.DbType.Int32;
                pSalary.Direction = System.Data.ParameterDirection.Input; // Default is Input
                pSalary.Value = 70000;
                Cmd.Parameters.Add(pSalary);

                var rdr = Cmd.ExecuteNonQuery();

                Conn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error :: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error :: {ex.Message}");
            }
            finally
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                Conn.Dispose();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }       
    }
}
