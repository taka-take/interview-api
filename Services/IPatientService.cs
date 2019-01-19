using System.Collections.Generic;
using interview_api.Entities;

namespace interview_api.Services
{
    public interface IPatientService
    {
        List<Patient> GetPatients();
        Patient GetPatient(int id);
        void AddPatient(Patient item);
        void UpdatePatient(Patient item);
        void DeletePatient(int id);
        bool PatientExists(int id);
    }
}