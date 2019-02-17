using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace DuetMobile.Services
{
    public static class GlobalDataStore
    {
        public static readonly HttpClient httpClient = new HttpClient();
    }
}
