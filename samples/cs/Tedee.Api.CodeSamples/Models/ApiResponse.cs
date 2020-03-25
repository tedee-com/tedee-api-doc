using System.Collections.Generic;
using System.Linq;

namespace Tedee.Api.CodeSamples.Models
{
    public class ApiResponse<TResult>
    {
        protected bool isSuccessStatusCode => (StatusCode >= 200) && (StatusCode <= 299);
        public bool Success => !ErrorMessages.Any() && isSuccessStatusCode;
        public List<string> ErrorMessages { get; set; }
        public int StatusCode { get; set; }
        public TResult Result { get; set; }
    }
}
