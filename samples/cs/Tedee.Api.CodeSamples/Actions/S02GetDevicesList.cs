using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Tedee.Api.CodeSamples.Helpers;
using Tedee.Api.CodeSamples.Models;

namespace Tedee.Api.CodeSamples.Actions
{
    public static class S02GetDevicesList
    {
        public static async Task GetDevices()
        {
            using (var client = await AppHelpers.CreateAndAuthenticateClient())
            {
                var responseMessage = await client.GetAsync("my/device");
                var response = await responseMessage.Content.ReadAsAsync<ApiResponse<List<Device>>>();

                Console.WriteLine($"Response status code: {response.StatusCode}");
                Console.WriteLine($"Response content: {JsonConvert.SerializeObject(response.Result)}");
            }
        }
    }
}
