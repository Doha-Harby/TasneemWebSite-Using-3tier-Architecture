namespace Tass_PL.Controllers
{
    public class MeasurementController(IMeasurementService measurementService) : Controller
    {
        private readonly IMeasurementService _measurementService = measurementService;

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMeasurement(AddMeasurementVM model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "بيانات غير صحيحة";
                return RedirectToAction("PatientDetails", "Patient", new { id = model.PatientId });
            }

            var result = await _measurementService.AddMeasurementAsync(model);

            if (!result)
            {
                TempData["Error"] = "فشل إضافة القياس";
            }
            else
            {
                TempData["Success"] = "تم إضافة القياس بنجاح";
            }

            return RedirectToAction("PatientDetails", "Patient", new { id = model.PatientId });
        }
    }
}
