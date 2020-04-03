using Tedee.Api.CodeSamples.Enums;

namespace Tedee.Api.CodeSamples.Models
{
    public class DeviceSoftwareVersion
    {
        public SoftwareType SoftwareType { get; set; }
        public string Version { get; set; }
        public bool UpdateAvailable { get; set; }
    }
}
