using System;
using System.Collections.Generic;
using Tedee.Api.CodeSamples.Enums;

namespace Tedee.Api.CodeSamples.Models
{
    public class Device
    {
        public int Id { get; set; }
        public int? ConnectedToId { get; set; }
        public string SerialNumber { get; set; }
        public string MacAddress { get; set; }
        public string Name { get; set; }
        public string UserIdentity { get; set; }
        public DeviceType? Type { get; set; }
        public DateTime? Created { get; set; }
        public int? Revision { get; set; }
        public int? DeviceRevision { get; set; }
        public int? TargetDeviceRevision { get; set; }
        public bool? IsConnected { get; set; }
        public AccessLevel? AccessLevel { get; set; }
        public DeviceSharedWith ShareDetails { get; set; }
        public IEnumerable<DeviceSoftwareVersion> SoftwareVersions { get; set; }
    }
}
