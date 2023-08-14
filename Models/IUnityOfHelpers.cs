using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SICE.Models
{
    public interface IUnityOfHelpers
    {
        sicedbEntities idbsiceContext { get; }
    }
}