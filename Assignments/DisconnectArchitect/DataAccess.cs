using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Data;              // this contains the dataset type

namespace DisconnectArchitect
{
    public class DataAccess
    {
        SqlConnection Conn;
        SqlDataAdapter DataAdapterDept;
        SqlDataAdapter DataAdapterEmp;
        DataSet Ds;
        DataRow DrFind;
#pragma warning disable CS8618 // Non-nullable field 'DataAdapterDept' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'DataAdapterEmp' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning disable CS8618 // Non-nullable field 'DrFind' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        public DataAccess()
#pragma warning restore CS8618 // Non-nullable field 'DrFind' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'DataAdapterEmp' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
#pragma warning restore CS8618 // Non-nullable field 'DataAdapterDept' must contain a non-null value when exiting constructor. Consider declaring the field as nullable.
        {
            Conn = new SqlConnection("Data Source=PPAWAR-LAP-0704\\MSSQLSERVER02;Initial Catalog=eShoppingCodi;Integrated Security=SSPI");
            Ds = new DataSet();   
        }
        public void Load()
        {
            DataAdapterDept = new SqlDataAdapter("Select * from Department", Conn);
            DataAdapterEmp = new SqlDataAdapter("Select * from Employee", Conn);
            DataAdapterDept.MissingSchemaAction = MissingSchemaAction.AddWithKey; //this is to take the key info as well with the table which is in unorder form by default
            DataAdapterEmp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataAdapterDept.Fill(Ds,"Department");
            DataAdapterEmp.Fill(Ds,"Employee");

            //Console.WriteLine(Ds.GetXml());
        }
        public void Insert()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DataRow DrNew = Ds.Tables["Department"].NewRow();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            DrNew["DeptNo"] = 150;
            DrNew["DeptName"] = "Recruitment";
            DrNew["Location"] = "Mumbai";
            DrNew["Capacity"] = 20;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Ds.Tables["Department"].Rows.Add(DrNew);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapterDept);
            // Update
            DataAdapterDept.Update(Ds, "Department");
        }
        public void Update(int dno)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8601 // Possible null reference assignment.
            DrFind = Ds.Tables["Department"].Rows.Find(dno);
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DrFind["DeptName"] = "dept_203";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            DrFind["Location"] = "Chennai";
            DrFind["Capacity"] = 210;
            //we can only pass the value which we want to update as well
            SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapterDept);
            // Update
            DataAdapterDept.Update(Ds, "Department");
            Console.WriteLine("Updated");
        }
        public void Delete(int dno)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8601 // Possible null reference assignment.
            DrFind = Ds.Tables["Department"].Rows.Find(dno);
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DrFind.Delete();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            
            SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapterDept);
            // Update
            DataAdapterDept.Update(Ds, "Department");
            Console.WriteLine($"Deleted Dept no :{dno}");
        }
        public void findRecored(int dno)
        {
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            DrFind = Ds.Tables["Department"].Rows.Find(dno);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            Console.WriteLine(DrFind["DeptName"]);
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapterDept);
            // Update
            DataAdapterDept.Update(Ds, "Department");
            Console.WriteLine($"Record of Dept no :{dno}");
        }
        public void CreateDataRelation()
        {

            //here we are creating foriegn key like relation, 2nd parameter is parent and 3rd parameter is child
#pragma warning disable CS8604 // Possible null reference argument for parameter 'childColumn' in 'DataRelation DataRelationCollection.Add(string? name, DataColumn parentColumn, DataColumn childColumn)'.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument for parameter 'parentColumn' in 'DataRelation DataRelationCollection.Add(string? name, DataColumn parentColumn, DataColumn childColumn)'.
            DataRelation DeptEmp = Ds.Relations.Add("DeptEmp",
            Ds.Tables["Department"].Columns["DeptNo"],
            Ds.Tables["Employee"].Columns["DeptNo"]);
#pragma warning restore CS8604 // Possible null reference argument for parameter 'parentColumn' in 'DataRelation DataRelationCollection.Add(string? name, DataColumn parentColumn, DataColumn childColumn)'.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8604 // Possible null reference argument for parameter 'childColumn' in 'DataRelation DataRelationCollection.Add(string? name, DataColumn parentColumn, DataColumn childColumn)'.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            foreach (DataRow item in Ds.Tables["Department"].Rows)
            {
                Console.WriteLine($"Dept no: {item["DeptNo"]}");
                DataRow[] a = item.GetChildRows(DeptEmp);
                foreach (DataRow row in a)
                {
                    Console.WriteLine($"Employee Name: {row["EmpName"]} Employee Salary: {row["Salary"]} Employee Designation: {row["Designation"]} deptNo:{row["DeptNo"]}");
                }
                
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
