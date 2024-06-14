using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Base.Service
{
    public abstract class MVCBaseService
    {
        protected readonly HttpClient _client;

        protected MVCBaseService(HttpClient client)
        {
            _client = client;
        }

        /// <summary>
        /// The is the API Endpoint for this resource
        /// </summary>
        protected abstract string EndpointUri { get; }

        public string GetBaseUrl() => _client.BaseAddress!.ToString().TrimEnd('/');
        public string GetEndpointUrl() => $"{GetBaseUrl().TrimEnd('/')}/{EndpointUri.TrimStart('/')}";


        


    }
}
