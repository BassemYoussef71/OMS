using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OMS.CoreBusniess
{
    public class Employee
    {
        [Key, DisplayName("Employee ID")]
        public int EmployeeId { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "First Name Is Manditory Field and canot Be Blank"),
            MaxLength(50),
            DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false,
                    ErrorMessage = "Last Name Is Manditory Field and canot Be Blank"),
                    MaxLength(50),
            DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;

        [MaxLength(10), DisplayName("Title")]
        public string? Title { get; set; } = string.Empty;

        [MaxLength(200), DisplayName("Address")]
        public string? Address { get; set; } = string.Empty;

        [MaxLength(50), DisplayName("City")]
        public string? City { get; set; } = string.Empty;

        [MaxLength(50), DisplayName("Region")]
        public string? Region { get; set; } = string.Empty;

        [MaxLength(10), DisplayName("Postal Code")]
        public string? PostalCode { get; set; } = string.Empty;

        [MaxLength(50), DisplayName("Country")]
        public string? Country { get; set; } = string.Empty;
        [MaxLength(18), DisplayName("Home Phone")]
        public string? Phone { get; set; } = string.Empty;
        [DisplayName("Date Of Birth")]
        public DateOnly? Dop { get; set; }

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "User Name is Mandatory field and Canot be blank"),
            MaxLength(50),
            DisplayName("User Name")]
        public string UserName { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false,
            ErrorMessage = "Password is Mandatory field and Canot be blank"),
            MaxLength(50),
            DisplayName("Password"),
            DataType(DataType.Password)]
        public string UserPassword { get; set; } = string.Empty;
        [MaxLength(250), 
            DisplayName("Image Url"),
            DataType(DataType.ImageUrl)] 
        public string? ImageUrl { get; set; } = string.Empty;
       
        [DisplayName("Basic Salary"), 
            DataType(DataType.Currency)] 
        public decimal? BasicSalary { get; set; } = 0;

        [DisplayName("Extra Salary"),
            DataType(DataType.Currency)]
        public decimal? ExtraSalary { get; set; } = 0;

        [DisplayName("Total Allowences"),
            DataType(DataType.Currency)]
        public decimal? TotalAllowences { get; set; } = 0;

        [DisplayName("Gross Salary"),
            DataType(DataType.Currency)]
        public decimal? GrossSalary { get; set; } = 0;

        [DisplayName("Total Deductions"),
            DataType(DataType.Currency)]
        public decimal? TotalDeductions { get; set; } = 0;

        [DisplayName("Net Salary"),
            DataType(DataType.Currency)]
        public decimal? NetSalary { get; set; } = 0;

        [DisplayName("Admin")]
        public bool Admin { get; set; } = false;




    }
}