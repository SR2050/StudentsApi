namespace StudentsApi.Models
{
    public class StudentsModel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; } = string.Empty;
        
        public  string StudentDepartment {  get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;

        public string StudentPhone { get; set; } = string.Empty;


    }
}
