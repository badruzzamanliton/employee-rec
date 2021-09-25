/// *******************************************************************************************
///	|| Creation History || 
///	-------------------------------------------------------------------------------------------
///	Copyright		:	Copyright© Md. Badruzzaman Liton. All rights reserved.
///	NameSpace		:	EmployeeInfoWebApp.DAL.EmployeGateway
/// Class           :   EmployeeManager
/// Inherits        :   None
///	Author			:	Md. Badruzzaman Liton
///	Purpose			:	This is a Controller Class Getway
///	Creation Date	:	23/09/2021
/// ===========================================================================================
/// || Modification History. ||
/// -------------------------------------------------------------------------------------------
///
///
///	 ------------------------------------------------------------------------------------------
///	*******************************************************************************************

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EmployeeInfoWebApp.Model;

namespace EmployeeInfoWebApp.DAL
{
    public class EmployeGateway : CommonGetway
    {
        #region Save Employee Records
        public int SaveData(Employee employee)
        {
            string query = "INSERT INTO Employee VALUES('" + employee.FirstName + "','" + employee.MiddleName + "','" + employee.LastName + "')";
            aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            int roweffected = aCommand.ExecuteNonQuery();
            aConnection.Close();
            return roweffected;
        }
        #endregion
        #region Get Employee Records
        public List<Employee> GetAllEmployees()
        {
            string query = "Select * from Employee";
            aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReder = aCommand.ExecuteReader();
            List<Employee> allEmployee = new List<Employee>();
            if (aReder.HasRows)
            {
                while (aReder.Read())
                {
                    Employee aEmployee = new Employee();
                    aEmployee.Id = int.Parse(aReder["Id"].ToString());
                    aEmployee.FirstName = aReder["FirstName"].ToString();
                    aEmployee.MiddleName = aReder["MiddleName"].ToString();
                    aEmployee.LastName = aReder["LastName"].ToString();                  
                    allEmployee.Add(aEmployee);
                } aReder.Close();
            } aConnection.Close();
            return allEmployee;
        }
        #endregion
        #region Delete Employee Record by ID
        public int DeleteData(int id)
        {
            aConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Employee where id='" +  Convert.ToInt32(id) + "'", aConnection);
            int roweffected = cmd.ExecuteNonQuery();
            aConnection.Close();
            return roweffected;
        }
        #endregion
        #region Upadte Employee Record by ID
        public int UpdateData(int id, string firstName, string middleName, string lastName)
        {
            aConnection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Employee SET FirstName='" + firstName + "',MiddleName='" + middleName + "',LastName='" + lastName + "'where id='" + id + "'", aConnection);
            int roweffected = cmd.ExecuteNonQuery();
            aConnection.Close();
            return roweffected;
        }
        #endregion
    }
}