using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBConnection.Model;

namespace DBConnection.DataAccess
{
    public class CategoryDataAccess:IDisposable
    {
        SqlConnection Conn;
        SqlCommand Cmd;

#pragma warning disable CS8618 // Non-nullable field 'Cmd' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public CategoryDataAccess()
#pragma warning restore CS8618 // Non-nullable field 'Cmd' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        {
            Conn = new SqlConnection("Data Source=PPAWAR-LAP-0704\\MSSQLSERVER02;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
        }

        public IEnumerable<Category> GetRecords()
        {
            List<Category> records = new List<Category>();
            try
            {
                // 1. Open the onection
                Conn.Open();
                // 2. Creating command
                Cmd = new SqlCommand();
                // Set the COnnection object to COmmand
                Cmd.Connection = Conn;
                // 2.a. Setting the Command Properties for TExt 
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Select * from Category";
                // 3. Execute
                SqlDataReader Reader = Cmd.ExecuteReader();
                // 3.a. STart REading Records
                while(Reader.Read())
                {
#pragma warning disable CS8601 // Possible null reference assignment.
                    records.Add(new Category()
                    {
                        CategoryId = Convert.ToInt32(Reader["CategoryId"]),
                        CategoryName = Reader["CategoryName"].ToString(),
                        BasePrice = Convert.ToDecimal(Reader["BasePrice"])
                    });
#pragma warning restore CS8601 // Possible null reference assignment.
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return records;
        }

        public Category CreateRecord(Category category)
        {
            try
            {
                Conn.Open();
                Cmd = Conn.CreateCommand();
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Insert into Category values(@CategoryId,@CategoryName,@BasePrice)";
                // Set Parmeters
                Cmd.Parameters.AddWithValue("@CategoryId", category.CategoryId);
                Cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                Cmd.Parameters.AddWithValue("@BasePrice", category.BasePrice);
                // Execute
                int res = Cmd.ExecuteNonQuery();
                if (res == 0)
                    throw new Exception("No Record Inserted");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return category;
        }
        public Category UpdateRecord(int id, Category category)
        {
            try
            {
                Conn.Open();
                Cmd = Conn.CreateCommand();
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Update Category set CategoryName=@CategoryName,BasePrice=@BasePrice Where CategoryId=@CategoryId";
                // Set Parmeters
                Cmd.Parameters.AddWithValue("@CategoryId", category.CategoryId);
                Cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                Cmd.Parameters.AddWithValue("@BasePrice", category.BasePrice);
                // Execute
                int res = Cmd.ExecuteNonQuery();
                if (res == 0)
                    throw new Exception("No REcord Updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return category;
        }
        public bool DeleteRecord(int id)
        {
            bool isDeleted = false;
            try
            {
                Conn.Open();
                Cmd = Conn.CreateCommand();
                Cmd.CommandType = System.Data.CommandType.Text;
                Cmd.CommandText = "Delete Category Where CategoryId=@CategoryId";
                // Set Parmeters
                Cmd.Parameters.AddWithValue("@CategoryId", id);

                // Execute
                int res = Cmd.ExecuteNonQuery();
                if (res == 0)
                    throw new Exception("No REcord Deleted");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return isDeleted;
        }
        public void Dispose()
        {
            Conn.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
