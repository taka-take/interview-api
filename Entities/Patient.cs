using System;

namespace interview_api.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public string FirstName { get; set; }
        public string FirstNameKana { get; set; }
        public string LastName { get; set; }
        public string LastNameKana { get; set; }
        public int Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public int ClinicId { get; set; }
        public string Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Updater { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}