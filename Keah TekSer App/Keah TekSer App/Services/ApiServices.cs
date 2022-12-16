using Keah_TekSer_App.Helpers;
using Keah_TekSer_App.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;


namespace Keah_TekSer_App.Services
{
    internal class ApiServices
    {
        string endPoint = "http://10.0.2.2:30360/";
        public async Task<ResponseBase<User>> Login(long id, string password)
        {
            var client = new HttpClient();
            var user = new User();
            user.PERSONEL_ID_NUMBER = id;
            user.PERSONEL_SIFRE = password;
            var json = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(endPoint + "user/login", content);
            var info = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ResponseBase<User>>(info);
            return data;
        }

        public async Task<ResponseBase<List<Call>>> UnresponsedCalls(string personelSeq, string token)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["PERSONEL_SEQ"] = personelSeq;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var json = await client.GetStringAsync(endPoint + "call/getUnresponsedCalls?" + query);
            var calls = JsonConvert.DeserializeObject<ResponseBase<List<Call>>>(json);
            return calls;
        }

        public async Task<ResponseBase<List<Call>>> GetAllCalls(string personelSeq, string token)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["PERSONEL_SEQ"] = personelSeq;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var json = await client.GetStringAsync(endPoint + "call/getAll?" + query);
            var calls = JsonConvert.DeserializeObject<ResponseBase<List<Call>>>(json);
            return calls;
        }

        public async Task<ResponseBase<Call>> ResponseCall(Response response, string token)
        {
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(response);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var result = await client.PostAsync(endPoint + "call/responseCall", content);
            var info = await result.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ResponseBase<Call>>(info);
            return data; 
        }

        public async Task<ResponseBase<BakimSebebi>> BakimSebebi(int sebepSeq, string token)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["BAKIM_SEBEBI_SEQ"] = sebepSeq.ToString();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var json = await client.GetStringAsync(endPoint + "call/getBakimSebebi?" + query);
            var reason = JsonConvert.DeserializeObject<ResponseBase<BakimSebebi>>(json);
            return reason;
        }
    }
}
