namespace Tass_BLL.Services.Implementation
{
    public class MeasurementService(IMeasurementRepo _repository, IMapper mapper) : Service<Measurements>(_repository), IMeasurementService
    {
        private readonly IMapper _mapper = mapper;
        public async Task<bool> AddMeasurementAsync(AddMeasurementVM model)
        {
            if (model == null)
                return false;

            var measurement = _mapper.Map<Measurements>(model);

            measurement.SetMeasurementDate(model.MeasurementDate ?? DateTime.Today);

            await _repository.CreateAysnc(measurement);

            return true;
        }
    }
}
