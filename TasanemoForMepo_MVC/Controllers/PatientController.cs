namespace Tass_PL.Controllers
{
    public class PatientController(IPatientService patientService) : Controller
    {
        private readonly IPatientService _patientService = patientService;
        public async Task<IActionResult> Index()
        {
            var patients = await _patientService.GetAllActivePatientsVMAsync();
            return View(patients);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePatientVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await _patientService.CreatePatientAsync(model);

            if (result.Success)
            {
                TempData["Success"] = "تم إضافة المريض بنجاح";
                return RedirectToAction(nameof(Index));
            }

            ModelState.AddModelError("", result.ErrorMessage ?? "حدث خطأ");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> PatientDetails(int id)
        {
            var viewModel = await _patientService.GetPatientDetailsAsync(id);

            if (viewModel == null)
                return NotFound();

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePatient(int id)
        {
            var viewModel = await _patientService.GetPatientDetailsAsync(id);
            if(viewModel == null) return NotFound();
            viewModel.IsEditMode = true;
            return View("PatientDetails", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdatePatient(PatientDetailsModifyModeVM model)
        {
            if (!ModelState.IsValid)
            {
                model.IsEditMode = true;
                return View("PatientDetails", model);
            }

            var updatePatientVM = new UpdatePatientVM
            {
                Id = model.Patient.Id,
                Name = model.Patient.Name,
                Age = model.Patient.Age,
                Hight = model.Patient.Hight,
                Job = model.Patient.Job,
                Diagnosis = model.Patient.Diagnosis,
                PhoneNumber = model.Patient.PhoneNumber,
                Notes = model.Patient.Notes
            };

            var updatedPatient = await _patientService.UpdatePatientAsync(updatePatientVM);

            if (updatedPatient != null)
            {
                TempData["Success"] = "تم تحديث بيانات المريض بنجاح";
                return RedirectToAction(nameof(PatientDetails), new { id = updatePatientVM.Id });
            }

            TempData["Error"] = "حدث خطأ أثناء تحديث بيانات المريض";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete(int id)
        {
            await patientService.SoftDeletePatientAsync(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> RestoreDeleted(int id)
        {
            await patientService.RestoreDeletedPatientAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> DeletedPatients()
        {
            var patients = await patientService.GetDeletedPatientsAsync();
            return View(patients);
        }
        [HttpPost]
        public async Task<IActionResult> HardDelete(int id)
        {
            await patientService.HardDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> PrintPatient(int id)
        {
            var vm = await _patientService.GetPatientDetailsForPrintAsync(id);

            if (vm == null)
                return NotFound();

            return View(vm);
        }
    }
}
