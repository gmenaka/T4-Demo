using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HtmlReporting.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
    }
    public class EmployeeMetadata
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [ReadOnly(true)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [ScaffoldColumn(true)]
        [DataType(DataType.Currency)]
        public int? Salary { get; set; }

        [DataType(DataType.Url)]
        [UIHint("OpenInNewWindow")]
        public string PersonalWebSite { get; set; }

        [DisplayAttribute(Name = "Full Name")]
        public string FullName { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? HireDate { get; set; }

        [DisplayFormat(NullDisplayText = "Gender not specified")]
        public string Gender { get; set; }
    }
}