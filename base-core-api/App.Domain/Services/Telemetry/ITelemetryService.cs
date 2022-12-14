using App.Common.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Telemetry
{
    public interface ITelemetryService
    {
        List<DetailDataContract> GetDataCsv();
    }
}
