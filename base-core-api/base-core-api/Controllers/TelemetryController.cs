using App.Common.Classes.DTO;
using App.Domain.Services.Telemetry;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace base_core_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelemetryController : ControllerBase
    {
        private readonly ITelemetryService _telemetryService;
        public TelemetryController(ITelemetryService telemetryService)
        {
            _telemetryService = telemetryService;
        }

        [HttpGet("GetData")]
        public List<DetailDataContract> GetData()
        {
            return _telemetryService.GetDataCsv();
        }
    }
}
