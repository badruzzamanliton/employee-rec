/// *******************************************************************************************
///	|| Creation History || 
///	-------------------------------------------------------------------------------------------
///	Copyright		:	Copyright© Md. Badruzzaman Liton. All rights reserved.
///	NameSpace		:	EmployeeInfoWebApp.BLL.EmployeeManager
/// Class           :   EmployeeManager
/// Inherits        :   None
///	Author			:	Md. Badruzzaman Liton
///	Purpose			:	This is a Controller Class
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
using System.Linq;
using System.Web;
using EmployeeInfoWebApp.DAL;
using EmployeeInfoWebApp.Model;

namespace EmployeeInfoWebApp.BLL
{
    public class EmployeeManager
    {
        #region Class Level Variable
        EmployeGateway aEmployeeGetway = new EmployeGateway();
        #endregion
        #region Save Employee Records
        public string SaveData(Employee employee)
        {
            var rowEffected = aEmployeeGetway.SaveData(employee);
            if (rowEffected > 0)
            {
                return "Data has been submited Successfully...";
            }
            else
            {
                return "Data submited failed!";
            }
        }
        #endregion
        #region Get Employee Records
        public List<Employee> GetAllEmployees()
        {
            return aEmployeeGetway.GetAllEmployees();
        }
        #endregion
        #region Delete Employee Record by ID
        public string DeleteData(int id)
        {
            var rowEffected = aEmployeeGetway.DeleteData(id);
            if (rowEffected > 0)
            {
                return "Data has Deleted...";
            }
            else
            {
                return "Data Delete failed!";
            }
        }
        #endregion
        #region Upadte Employee Record by ID
        public string UpdateData(int id, string firstName, string middleName, string lastName)
        {
            var rowEffected = aEmployeeGetway.UpdateData(id, firstName, middleName, lastName);
            if (rowEffected > 0)
            {
                return "Data has Updated...";
            }
            else
            {
                return "Data Update failed!";
            }
        }
        #endregion
    }
}