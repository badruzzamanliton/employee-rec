/// <summary>
/// <para>
///   ================================================================ 
///     Class File    : CommonGetway
///		Author        : Md. Badruzzaman Liton
///		Purpose       : Used for common getway DAL.
///		Creation Date :	23/09/2021
///		=================================================================
///		Modification History
///		Author     :
///		Purpose    : 
///		Date       :

///	<para>
/// </summary> 	

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace EmployeeInfoWebApp.DAL
{
    public class CommonGetway
    {
        public string connectionString = WebConfigurationManager.ConnectionStrings["EmployeeManagement"].ConnectionString;
        public SqlConnection aConnection;
        public SqlCommand aCommand;

        public CommonGetway()
        {
            aConnection = new SqlConnection(connectionString);
        }
    }
}