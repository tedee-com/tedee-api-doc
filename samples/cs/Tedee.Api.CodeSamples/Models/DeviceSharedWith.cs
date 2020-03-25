using Tedee.Api.CodeSamples.Enums;

namespace Tedee.Api.CodeSamples.Models
{
    public class DeviceSharedWith
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public string UserIdentity { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public AccessType AccessType { get; set; }
        public string UserEmail { get; set; }
        public bool IsPending { get; set; }
        public string UserDisplayName { get; set; }
        public RepeatEvent RepeatEvent { get; set; }
    }
}
