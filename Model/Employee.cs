/// <summary>
/// <para>
///================================================================
///		Model id   : 0.0.0.
///		Model name : Employee
///		Author     : Md. Badruzzaman Liton
///		Purpose    : Used Model of records get and set.
///		Creation   : 23/09/2031
///================================================================
///		Modification History
///		Author	 Date        Description of change
///	</para> 
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInfoWebApp.Model
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}