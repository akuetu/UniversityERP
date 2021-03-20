using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Enrollment.Services.Interfaces
{
    public interface IHttpHelperService
    {
        Task<List<T>> GetJsonListData<T>(string url, HttpClient httpClient);
        Task<T> GetJsonData<T>(string url, HttpClient httpClient);
    }
}
