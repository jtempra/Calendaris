using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Calendaris.Client.Repos
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public bool Error { get; set; } //error en la peticio http
        public T Response { get; set; } // resposta deserialitzada
        public HttpResponseMessage HttpResponseMessage { get; set; } // resposta complerta

        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
