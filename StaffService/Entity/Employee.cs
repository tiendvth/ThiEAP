using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StaffService.Entity
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        [Key]
        public string EmployeeID { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public string Salary { get; set; }
        [DataMember]
        public string Department { get; set; }
    }
}