using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples.Actions
{
    public class DeviceActions : ActionsBase
    {
        public DeviceActions(ApiHttpClient apiClient) : base(apiClient)
        {
        }

        public async Task GetDevicesCount()
        {
            var response = await _apiClient.GetAsync("my/device");
            var devices = (await response.Content.ReadAsAsync<ApiResponse<List<Device>>>()).Result;

            Console.WriteLine($"Your devices count: {devices.Count}");
        }
    }
}
