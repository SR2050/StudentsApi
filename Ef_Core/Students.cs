using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentsApi.Ef_Core
{
    [Table("StudentsDb")]
    public class Students
    {
        [Key, Required]

        public int StudentsId { get; set; }

        [Required]

        public string StudentName { get; set; } = string.Empty;

        [Required]
        public string StudentDepartment { get; set; } = string.Empty;
        [Required]
        public string StudentEmail { get; set; } = string.Empty;
        [Required]
        public string StudentPhone { get; set; } = string.Empty;
    }
}
