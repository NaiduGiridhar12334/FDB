using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBApiConnector.Common
{
    public interface IApiClient
    {
        Task<TResponse> GetAsync<TResponse>(string requestUri);
    }
}
