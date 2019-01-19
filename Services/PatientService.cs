using System.Collections.Generic;
using System.Linq;
using interview_api.Entities;

namespace interview_api.Services
{
    public class PatientService : IPatientService
    {
        private readonly List<Patient> patients;

        public PatientService()
        {
            this.patients = new List<Patient>
            {
                new Patient { Id = 1 },
                new Patient { Id = 2 },
                new Patient { Id = 3 }
            };
        }
        public List<Patient> GetPatients() => this.patients.ToList();
        public Patient GetPatient(int id) => this.patients.Where(x => x.Id == id).FirstOrDefault();
        public void AddPatient(Patient item) => this.patients.Add(item);
        public void UpdatePatient(Patient item)
        {
            var model = this.patients.Where(x => x.Id == item.Id).FirstOrDefault();

            model.PatientCode = item.PatientCode;
            model.FirstName = item.FirstName;
            model.FirstNameKana = item.FirstNameKana;
            model.LastName = item.LastName;
            model.LastNameKana = item.LastNameKana;
            model.Sex = item.Sex;
            model.BirthDate = item.BirthDate;
            model.ZipCode = item.ZipCode;
            model.Address = item.Address;
            model.Phone = item.Phone;
            model.Mobile = item.Mobile;
            model.Mail = item.Mail;
            model.ClinicId = item.ClinicId;
            model.Updater = item.Updater;
            model.UpdatedAt = item.UpdatedAt;
        }
        public void DeletePatient(int id)
        {
            var model = this.patients.Where(x => x.Id == id).FirstOrDefault();

            this.patients.Remove(model);
        }
        public bool PatientExists(int id) => this.patients.Any(x => x.Id == id);
    }
}