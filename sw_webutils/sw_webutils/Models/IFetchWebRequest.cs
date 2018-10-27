using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sw_webutils.Models
{
    interface IFetchWebRequest
    {
        Task<string> fetchWebRequest(string url);
    }
}
