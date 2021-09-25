///******************************************************************
///	|| Creation History ||
///--------------------------------------------------------------------
///	Copyright	  : Copyright© Md. Badruzzaman Liton. All rights reserved.
///	NameSpace	  :	EmployeeInfoWebApp.UI
/// UI Name       : EmployeeInfoWebApp
/// Inherits      : EmployeeInfoWebApp.UI.EmployeeUI
///	Author	      :	Md. Badruzzaman Liton
///	Purpose	      :	Employee Records Entry UI
///	Creation Date :	23/09/2021
/// =======================================================================
///  || Modification History ||
///  ------------------------------------------------------------------
///  Sl No.	Date:		Author:			Ver:	Area of Change:
///  1
///	 ----------------------------------------------------------------
///	*****************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeInfoWebApp.BLL;
using EmployeeInfoWebApp.Model;

namespace EmployeeInfoWebApp.UI
{
    public partial class EmployeeUI : System.Web.UI.Page
    {
        #region Class Level Variable
        EmployeeManager aEmployeeManager = new EmployeeManager();
        #endregion
        #region Page_Load()
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // first name TextBox focus 
                firstNameTextBox.Focus();
                empRecInfo.Visible = false;
                pnlEmpRec.Visible = false;
            }
        }
        #endregion
        #region User Defined Methods
        protected void showMessageBox(string message)
        {
            string sScript;
            message = message.Replace("'", "\'");
            sScript = String.Format("alert('{0}');", message);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", sScript, true);
        }
        public bool Validation()
        {
            if (!Regex.Match(firstNameTextBox.Text, "^[^0-9]*$").Success)
            {
                // first name was incorrect  
                messageLabel.InnerText = "Invalid first name";
                firstNameTextBox.Focus();
                return true;
            }
            if (!Regex.Match(lastNameTextBox.Text, "^[^0-9]*$").Success)
            {
                // first name was incorrect  
                messageLabel.InnerText = "Invalid first name";
                lastNameTextBox.Focus();
                return true;
            }
            if (!Regex.Match(middleNameTextBox.Text, "^[^0-9]*$").Success)
            {
                // first name was incorrect  
                messageLabel.InnerText = "Invalid first name";
                middleNameTextBox.Focus();
                return true;
            }
            if (firstNameTextBox.Text == string.Empty)
            {
                // first name was empty  
                showMessageBox("Please input First Name!!!");
                return true;
            }
            if (lastNameTextBox.Text == string.Empty)
            {
                // last name was empty  
                messageLabel.InnerText = "Please input Last Name!!!";
                return true;
            }                    
            return false;
        }
        private void SaveData()
        {
            Employee employee = new Employee();
            if (Validation())
            {
                return;
            }
            try
            {
                employee.FirstName = firstNameTextBox.Text.Trim();
                employee.MiddleName = middleNameTextBox.Text.Trim();
                employee.LastName = lastNameTextBox.Text.Trim();

                messageLabel.InnerText = aEmployeeManager.SaveData(employee);
                GetAllEmployeeInGridView();
                Clear();
            }
            catch
            {
                showMessageBox("Error occurred!!!");
            }           
        }
        private void Clear()
        {
            //TextBox empty
            firstNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }
        public void GetAllEmployeeInGridView()
        {
            List<Employee> aEmployee = aEmployeeManager.GetAllEmployees();
            if (aEmployee.Count > 0)
            {
                showEmpGridView.DataSource = aEmployee;
                showEmpGridView.DataBind();
            }
            else
            {
                showMessageBox("No Employee Data found!");
            }
            ViewState["AllEmploye"] = aEmployee;
        }
        #endregion
        #region Event Defined Methods
        protected void submitButton_Click(object sender, EventArgs e)
        {
            //Insert data methoed
            SaveData();
        }
        protected void refreshButton_Click(object sender, EventArgs e)
        {
            Clear();
            messageLabel.InnerText = string.Empty;
            empRecInfo.Visible = false;
            pnlEmpRec.Visible = false;
        }
        protected void showlButton_Click(object sender, EventArgs e)
        {
            GetAllEmployeeInGridView();
            messageLabel.InnerText = string.Empty;
            empRecInfo.Visible = true;
            pnlEmpRec.Visible = true;
        }
        protected void showEmpGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(showEmpGridView.DataKeys[e.RowIndex].Value.ToString());

            messageLabel.InnerText = aEmployeeManager.DeleteData(id);
            GetAllEmployeeInGridView();
        }
        protected void showEmpGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            showEmpGridView.EditIndex = e.NewEditIndex;
            GetAllEmployeeInGridView();
        }
        protected void showEmpGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(showEmpGridView.DataKeys[e.RowIndex].Value.ToString());

            string firstName = ((TextBox)showEmpGridView.Rows[e.RowIndex].Cells[0].Controls[0]).Text;
            string middleName = ((TextBox)showEmpGridView.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string lastName = ((TextBox)showEmpGridView.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            showEmpGridView.EditIndex = -1;
            messageLabel.InnerText = aEmployeeManager.UpdateData(id, firstName, middleName, lastName);
            showEmpGridView.DataBind();
            GetAllEmployeeInGridView();
        }
        protected void showEmpGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            showEmpGridView.PageIndex = e.NewPageIndex;
            GetAllEmployeeInGridView();
        }
        protected void showEmpGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            showEmpGridView.EditIndex = -1;
            GetAllEmployeeInGridView();
        }
        #endregion
    }
}