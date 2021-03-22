using MicroRabbit.Mvc.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.Mvc.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiClient;
        public TransferService(HttpClient apiClient)
        {
            _apiClient = apiClient;

        }
        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "http://microrabbit.banking.api/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDto), 
                                        System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync(uri, transferContent);

            response.EnsureSuccessStatusCode();

        }
    }
}
