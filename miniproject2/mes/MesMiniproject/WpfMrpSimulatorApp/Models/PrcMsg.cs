﻿using Microsoft.Extensions.Primitives;

namespace WpfMrpSimulatorApp.Models
{
    // JSON용 클래스 딴데 안씀,,,
    public class PrcMsg
    {
        public string ClientId { get; set; }
        public string PlantCode { get; set; }
        public string FacilityId { get; set; }
        public string Timestamp { get; set; }
        public string Flag { get; set; }
    }
}
