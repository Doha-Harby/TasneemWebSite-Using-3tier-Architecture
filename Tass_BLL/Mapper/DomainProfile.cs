using System.Diagnostics.Metrics;
using Tass_DAL.Entities;

namespace Tass_BLL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            // Patients Mappings
            CreateMap<Patients, GetAllActivePatientsVM>()
                .ReverseMap();
            CreateMap<Patients, GetAllDeletedPatientsVM>()
               .ReverseMap();

            CreateMap<Patients, PatientDetailsVM>()
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn ?? DateTime.Now))
                .ReverseMap();

            CreateMap<Patients, PatientDetailsModifyModeVM>()
                .ForMember(dest => dest.Measurements, opt => opt.MapFrom(src => src.Measurements))
                .ForMember(dest => dest.NewMeasurement, opt => opt.Ignore())
                .ForMember(dest => dest.IsEditMode, opt => opt.Ignore());

            // CreatePatientVM to Patients
            CreateMap<CreatePatientVM, Patients>()
                .ConstructUsing(src => new Patients(
                    src.Name ?? string.Empty,
                    src.Age,
                    src.Hight,
                    src.Job ?? string.Empty,
                    src.Diagnosis ?? string.Empty,
                    src.PhoneNumber ?? string.Empty,
                    src.Notes ?? string.Empty
                ));

            // Measurements Mappings
            CreateMap<Measurements, MeasurementVM>()
                .ReverseMap();

            CreateMap<AddMeasurementVM, Measurements>()
                .ReverseMap();
        }
    }
}