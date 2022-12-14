using App.Common.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Telemetry
{
    public class TelemetryService : ITelemetryService
    {
        public List<DetailDataContract> GetDataCsv()
        {
            List<DetailDataContract> response = new List<DetailDataContract>();
            List<string> data = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(@"D:\Prueba Tecnica\Celsia\Prueba tecnica Desarrollo\DevOps I Lite\Telemetria\Csv\00086234-9179-4506-aa25-88d7a98043df.csv");
            lines = lines.Skip(1).ToArray();
            foreach (var item in lines)
            {
                data.Add(item);
            }
            foreach (var item in data)
            {
                string[] dataSeparate = item.Split(",");
                DetailDataContract detailData = new DetailDataContract()
                {
                    ConnectionDeviceID = dataSeparate[0],
                    EventProcessedUtcTime = dataSeparate[1],
                    HefestoID = dataSeparate[2],
                    Timestamp = dataSeparate[3],
                    LongDescription = dataSeparate[4],
                    DetailValue = dataSeparate[5],
                    Plugin = dataSeparate[6],
                    Request = dataSeparate[7],
                    Description = dataSeparate[8],
                    Device = Convert.ToInt32(dataSeparate[9])
                };
                response.Add(detailData);
            }
            return response;
        }
    }
}
