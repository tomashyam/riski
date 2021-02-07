using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Credit
{
    public class Visa : ICreditCompeny
    {
        // Better to create abstract Company that execute the procee like (make request, handle response and so..)

        // TODO : Config
        private const string _url = "https://interview.riskxint.com/visa/api/chargeCard";
        private const string SUCCESS_NAME = "Success";
        private HttpClient _httpCLient;
        public Visa(HttpClient httpClient)
        {
            _httpCLient = httpClient;
        }
        public async Task<APIResponse> ChargeCredit(TransactionInfo transaction)
        {
            // TODO: Convert to VisaModel;
            var srtingContent = new StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json");
            var response = await _httpCLient.PostAsync(_url, srtingContent);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var stringResponse = await response.Content.ReadAsStringAsync();
            var jsonResponse = JsonConvert.DeserializeObject<JObject>(stringResponse);

            if (jsonResponse["chargeResult"].Value<string>() == SUCCESS_NAME)
            {
                return CreateSuccesResponse();
            }
            else
            {
                return CreateFailResponse(jsonResponse);
            }
        }

        private APIResponse CreateFailResponse(JObject jsonResponse)
        {
            return new APIResponse()
            {
                Error = jsonResponse["resultReason"].Value<string>()
            };
        }

        private APIResponse CreateSuccesResponse()
        {
            return new APIResponse()
            {
                Error = null
            };
        }
    }
}
