using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using Enrollment.Services.Interfaces;

namespace Enrollment.Services
{
    public class HttpHelperService : IHttpHelperService
    {
        public async Task<List<T>> GetJsonListData<T>(string url, HttpClient httpClient)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<List<T>>(url);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception( ex.Message);
            }
            catch (NotSupportedException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (JsonException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> GetJsonData<T>(string url, HttpClient httpClient)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<T>(url);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (JsonException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
