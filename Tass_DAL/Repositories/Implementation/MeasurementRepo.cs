
using System;

namespace Tass_DAL.Repositories.Implementation
{
    public class MeasurementRepo(TasneemContext context) : Repository<Measurements>(context), IMeasurementRepo
    {
       
    }
}
