using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using interview_api.Entities;
using interview_api.Models;
using interview_api.Services;

namespace interview_api.Controllers
{
    [Route("patients")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService patientService;

        public PatientsController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = patientService.GetPatients();

            var outputModel = ToOutputModel(model);

            return Ok(outputModel);
        }

        [HttpGet("{id}", Name = "GetPatient")]
        public IActionResult Get(int id)
        {
            var model = patientService.GetPatient(id);
            if (model == null)
                return NotFound();
            
            var outputModel = ToOutputModel(model);
            return Ok(outputModel);
        }

        private PatientOutputModel ToOutputModel(Patient model)
        {
            return new PatientOutputModel
            {
                Id = model.Id,
                PatientCode = model.PatientCode,
                FirstName = model.FirstName,
                FirstNameKana = model.FirstNameKana,
                LastName = model.LastName,
                LastNameKana = model.LastNameKana,
                Sex = model.Sex,
                BirthDate = model.BirthDate,
                ZipCode = model.ZipCode,
                Address = model.Address,
                Phone = model.Phone,
                Mobile = model.Mobile,
                Mail = model.Mail,
                ClinicId = model.ClinicId,
                Creator = model.Creator,
                CreatedAt = model.CreatedAt,
                Updater = model.Updater,
                UpdatedAt = model.UpdatedAt
            };
        }
        private List<PatientOutputModel> ToOutputModel(List<Patient> model) =>
        model.Select(x => ToOutputModel(x)).ToList();

        private Patient ToDomainModel(PatientInputModel inputModel)
        {
            return new Patient
            {
                Id = inputModel.Id,
                PatientCode = inputModel.PatientCode,
                FirstName = inputModel.FirstName,
                FirstNameKana = inputModel.FirstNameKana,
                LastName = inputModel.LastName,
                LastNameKana = inputModel.LastNameKana,
                Sex = inputModel.Sex,
                BirthDate = inputModel.BirthDate,
                ZipCode = inputModel.ZipCode,
                Address = inputModel.Address,
                Phone = inputModel.Phone,
                Mobile = inputModel.Mobile,
                Mail = inputModel.Mail,
                ClinicId = inputModel.ClinicId
            };
        }

        private PatientInputModel ToInputModel(Patient model)
        {
            return new PatientInputModel
            {
                Id = model.Id,
                PatientCode = model.PatientCode,
                FirstName = model.FirstName,
                FirstNameKana = model.FirstNameKana,
                LastName = model.LastName,
                LastNameKana = model.LastNameKana,
                Sex = model.Sex,
                BirthDate = model.BirthDate,
                ZipCode = model.ZipCode,
                Address = model.Address,
                Phone = model.Phone,
                Mobile = model.Mobile,
                Mail = model.Mail,
                ClinicId = model.ClinicId
            };
        }
    }
}