using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sw_webutils.Models
{
    interface IWebData<T>
    {
        T GetWebData();
    }
}

    