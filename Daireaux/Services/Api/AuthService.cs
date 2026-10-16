using Daireaux.Models.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daireaux.Services.Api
{
    public interface AuthService
    {
        string Token { get; }
        bool IsAuthenticated { get; }
        string BaseUrl { get; }
        Uri BaseUri { get; }
        void SetBaseUrl(string url);
        ApiRequest<object, object> Login(string email, string password, string baseUrl);
        void Logout();
    }
}
